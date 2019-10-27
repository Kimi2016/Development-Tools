# coding:utf-8
import os
import codecs

#targetdir = "E:\WorkSpace\client_Manghuangji_Trunk_Android\Assets\R\Inside\Lua\Protobuf\Protobuf.lua" # 绝对路径
targetdir = "..\..\client_Manghuangji_Trunk_Android\Assets\R\Inside\Lua\Protobuf\Protobuf.lua"  # 相对路径

contentformatprefix = '''pb = require 'pb'
protoc = require 'LuaFramework/protoc.lua'
assert(protoc:load[[\n'''

contentformatsuffix = '''\n]])'''


def getfilepaths(subdir, suffixname):
    filePaths = []
    for root, dirs, files in os.walk(os.path.curdir):
        if root == subdir:  # 指定目录文件名称
            for file in files:
                if os.path.splitext(file)[1] == suffixname:  # 匹配后缀名称
                    filePaths.append(os.path.join(root, file))
    return filePaths


def readfile(filepath, list):
    try:
        fileopen = codecs.open(filepath, 'r', 'utf-8')  # r 代表read
        list.extend(fileopen.readlines())
        fileopen.close()
    except UnicodeDecodeError as e:
        # print(e)
        fileopen = codecs.open(filepath, 'r')  # r 代表read
        list.extend(fileopen.readlines())
        fileopen.close()


def readallfiles(filepaths):
    contentlist = []
    for filepath in filepaths:
        readfile(filepath, contentlist)
    return contentlist


def writefile(filepath, contentlist):
    fileopen = codecs.open(filepath, 'w', 'utf-8')  # r 代表write
    fileopen.write(contentformatprefix)

    for line in contentlist:
        if not 'import' in line:
            fileopen.write('\t' + line)
        else:
            fileopen.write("\n")


    fileopen.write(contentformatsuffix)
    fileopen.close()


if __name__ == '__main__':
    filePaths = getfilepaths('.\\proto', '.txt')
    allcontentlist = readallfiles(filePaths)
    writefile(targetdir, allcontentlist)