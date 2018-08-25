using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class FairyGUI_RelationType_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.RelationType);

            field = type.GetField("Left_Left", flag);
            app.RegisterCLRFieldGetter(field, get_Left_Left_0);
            field = type.GetField("Left_Center", flag);
            app.RegisterCLRFieldGetter(field, get_Left_Center_1);
            field = type.GetField("Left_Right", flag);
            app.RegisterCLRFieldGetter(field, get_Left_Right_2);
            field = type.GetField("Center_Center", flag);
            app.RegisterCLRFieldGetter(field, get_Center_Center_3);
            field = type.GetField("Right_Left", flag);
            app.RegisterCLRFieldGetter(field, get_Right_Left_4);
            field = type.GetField("Right_Center", flag);
            app.RegisterCLRFieldGetter(field, get_Right_Center_5);
            field = type.GetField("Right_Right", flag);
            app.RegisterCLRFieldGetter(field, get_Right_Right_6);
            field = type.GetField("Top_Top", flag);
            app.RegisterCLRFieldGetter(field, get_Top_Top_7);
            field = type.GetField("Top_Middle", flag);
            app.RegisterCLRFieldGetter(field, get_Top_Middle_8);
            field = type.GetField("Top_Bottom", flag);
            app.RegisterCLRFieldGetter(field, get_Top_Bottom_9);
            field = type.GetField("Middle_Middle", flag);
            app.RegisterCLRFieldGetter(field, get_Middle_Middle_10);
            field = type.GetField("Bottom_Top", flag);
            app.RegisterCLRFieldGetter(field, get_Bottom_Top_11);
            field = type.GetField("Bottom_Middle", flag);
            app.RegisterCLRFieldGetter(field, get_Bottom_Middle_12);
            field = type.GetField("Bottom_Bottom", flag);
            app.RegisterCLRFieldGetter(field, get_Bottom_Bottom_13);
            field = type.GetField("Width", flag);
            app.RegisterCLRFieldGetter(field, get_Width_14);
            field = type.GetField("Height", flag);
            app.RegisterCLRFieldGetter(field, get_Height_15);
            field = type.GetField("LeftExt_Left", flag);
            app.RegisterCLRFieldGetter(field, get_LeftExt_Left_16);
            field = type.GetField("LeftExt_Right", flag);
            app.RegisterCLRFieldGetter(field, get_LeftExt_Right_17);
            field = type.GetField("RightExt_Left", flag);
            app.RegisterCLRFieldGetter(field, get_RightExt_Left_18);
            field = type.GetField("RightExt_Right", flag);
            app.RegisterCLRFieldGetter(field, get_RightExt_Right_19);
            field = type.GetField("TopExt_Top", flag);
            app.RegisterCLRFieldGetter(field, get_TopExt_Top_20);
            field = type.GetField("TopExt_Bottom", flag);
            app.RegisterCLRFieldGetter(field, get_TopExt_Bottom_21);
            field = type.GetField("BottomExt_Top", flag);
            app.RegisterCLRFieldGetter(field, get_BottomExt_Top_22);
            field = type.GetField("BottomExt_Bottom", flag);
            app.RegisterCLRFieldGetter(field, get_BottomExt_Bottom_23);
            field = type.GetField("Size", flag);
            app.RegisterCLRFieldGetter(field, get_Size_24);


            app.RegisterCLRCreateDefaultInstance(type, () => new FairyGUI.RelationType());
            app.RegisterCLRCreateArrayInstance(type, s => new FairyGUI.RelationType[s]);


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref FairyGUI.RelationType instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as FairyGUI.RelationType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Left_Left_0(ref object o)
        {
            return FairyGUI.RelationType.Left_Left;
        }
        static object get_Left_Center_1(ref object o)
        {
            return FairyGUI.RelationType.Left_Center;
        }
        static object get_Left_Right_2(ref object o)
        {
            return FairyGUI.RelationType.Left_Right;
        }
        static object get_Center_Center_3(ref object o)
        {
            return FairyGUI.RelationType.Center_Center;
        }
        static object get_Right_Left_4(ref object o)
        {
            return FairyGUI.RelationType.Right_Left;
        }
        static object get_Right_Center_5(ref object o)
        {
            return FairyGUI.RelationType.Right_Center;
        }
        static object get_Right_Right_6(ref object o)
        {
            return FairyGUI.RelationType.Right_Right;
        }
        static object get_Top_Top_7(ref object o)
        {
            return FairyGUI.RelationType.Top_Top;
        }
        static object get_Top_Middle_8(ref object o)
        {
            return FairyGUI.RelationType.Top_Middle;
        }
        static object get_Top_Bottom_9(ref object o)
        {
            return FairyGUI.RelationType.Top_Bottom;
        }
        static object get_Middle_Middle_10(ref object o)
        {
            return FairyGUI.RelationType.Middle_Middle;
        }
        static object get_Bottom_Top_11(ref object o)
        {
            return FairyGUI.RelationType.Bottom_Top;
        }
        static object get_Bottom_Middle_12(ref object o)
        {
            return FairyGUI.RelationType.Bottom_Middle;
        }
        static object get_Bottom_Bottom_13(ref object o)
        {
            return FairyGUI.RelationType.Bottom_Bottom;
        }
        static object get_Width_14(ref object o)
        {
            return FairyGUI.RelationType.Width;
        }
        static object get_Height_15(ref object o)
        {
            return FairyGUI.RelationType.Height;
        }
        static object get_LeftExt_Left_16(ref object o)
        {
            return FairyGUI.RelationType.LeftExt_Left;
        }
        static object get_LeftExt_Right_17(ref object o)
        {
            return FairyGUI.RelationType.LeftExt_Right;
        }
        static object get_RightExt_Left_18(ref object o)
        {
            return FairyGUI.RelationType.RightExt_Left;
        }
        static object get_RightExt_Right_19(ref object o)
        {
            return FairyGUI.RelationType.RightExt_Right;
        }
        static object get_TopExt_Top_20(ref object o)
        {
            return FairyGUI.RelationType.TopExt_Top;
        }
        static object get_TopExt_Bottom_21(ref object o)
        {
            return FairyGUI.RelationType.TopExt_Bottom;
        }
        static object get_BottomExt_Top_22(ref object o)
        {
            return FairyGUI.RelationType.BottomExt_Top;
        }
        static object get_BottomExt_Bottom_23(ref object o)
        {
            return FairyGUI.RelationType.BottomExt_Bottom;
        }
        static object get_Size_24(ref object o)
        {
            return FairyGUI.RelationType.Size;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new FairyGUI.RelationType();
            ins = (FairyGUI.RelationType)o;
            return ins;
        }


    }
}
