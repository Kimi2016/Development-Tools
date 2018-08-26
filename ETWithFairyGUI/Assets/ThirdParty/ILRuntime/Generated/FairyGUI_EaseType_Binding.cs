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
    unsafe class FairyGUI_EaseType_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.EaseType);

            field = type.GetField("Linear", flag);
            app.RegisterCLRFieldGetter(field, get_Linear_0);
            field = type.GetField("SineIn", flag);
            app.RegisterCLRFieldGetter(field, get_SineIn_1);
            field = type.GetField("SineOut", flag);
            app.RegisterCLRFieldGetter(field, get_SineOut_2);
            field = type.GetField("SineInOut", flag);
            app.RegisterCLRFieldGetter(field, get_SineInOut_3);
            field = type.GetField("QuadIn", flag);
            app.RegisterCLRFieldGetter(field, get_QuadIn_4);
            field = type.GetField("QuadOut", flag);
            app.RegisterCLRFieldGetter(field, get_QuadOut_5);
            field = type.GetField("QuadInOut", flag);
            app.RegisterCLRFieldGetter(field, get_QuadInOut_6);
            field = type.GetField("CubicIn", flag);
            app.RegisterCLRFieldGetter(field, get_CubicIn_7);
            field = type.GetField("CubicOut", flag);
            app.RegisterCLRFieldGetter(field, get_CubicOut_8);
            field = type.GetField("CubicInOut", flag);
            app.RegisterCLRFieldGetter(field, get_CubicInOut_9);
            field = type.GetField("QuartIn", flag);
            app.RegisterCLRFieldGetter(field, get_QuartIn_10);
            field = type.GetField("QuartOut", flag);
            app.RegisterCLRFieldGetter(field, get_QuartOut_11);
            field = type.GetField("QuartInOut", flag);
            app.RegisterCLRFieldGetter(field, get_QuartInOut_12);
            field = type.GetField("QuintIn", flag);
            app.RegisterCLRFieldGetter(field, get_QuintIn_13);
            field = type.GetField("QuintOut", flag);
            app.RegisterCLRFieldGetter(field, get_QuintOut_14);
            field = type.GetField("QuintInOut", flag);
            app.RegisterCLRFieldGetter(field, get_QuintInOut_15);
            field = type.GetField("ExpoIn", flag);
            app.RegisterCLRFieldGetter(field, get_ExpoIn_16);
            field = type.GetField("ExpoOut", flag);
            app.RegisterCLRFieldGetter(field, get_ExpoOut_17);
            field = type.GetField("ExpoInOut", flag);
            app.RegisterCLRFieldGetter(field, get_ExpoInOut_18);
            field = type.GetField("CircIn", flag);
            app.RegisterCLRFieldGetter(field, get_CircIn_19);
            field = type.GetField("CircOut", flag);
            app.RegisterCLRFieldGetter(field, get_CircOut_20);
            field = type.GetField("CircInOut", flag);
            app.RegisterCLRFieldGetter(field, get_CircInOut_21);
            field = type.GetField("ElasticIn", flag);
            app.RegisterCLRFieldGetter(field, get_ElasticIn_22);
            field = type.GetField("ElasticOut", flag);
            app.RegisterCLRFieldGetter(field, get_ElasticOut_23);
            field = type.GetField("ElasticInOut", flag);
            app.RegisterCLRFieldGetter(field, get_ElasticInOut_24);
            field = type.GetField("BackIn", flag);
            app.RegisterCLRFieldGetter(field, get_BackIn_25);
            field = type.GetField("BackOut", flag);
            app.RegisterCLRFieldGetter(field, get_BackOut_26);
            field = type.GetField("BackInOut", flag);
            app.RegisterCLRFieldGetter(field, get_BackInOut_27);
            field = type.GetField("BounceIn", flag);
            app.RegisterCLRFieldGetter(field, get_BounceIn_28);
            field = type.GetField("BounceOut", flag);
            app.RegisterCLRFieldGetter(field, get_BounceOut_29);
            field = type.GetField("BounceInOut", flag);
            app.RegisterCLRFieldGetter(field, get_BounceInOut_30);
            field = type.GetField("Custom", flag);
            app.RegisterCLRFieldGetter(field, get_Custom_31);


            app.RegisterCLRCreateDefaultInstance(type, () => new FairyGUI.EaseType());
            app.RegisterCLRCreateArrayInstance(type, s => new FairyGUI.EaseType[s]);


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref FairyGUI.EaseType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as FairyGUI.EaseType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Linear_0(ref object o)
        {
            return FairyGUI.EaseType.Linear;
        }
        static object get_SineIn_1(ref object o)
        {
            return FairyGUI.EaseType.SineIn;
        }
        static object get_SineOut_2(ref object o)
        {
            return FairyGUI.EaseType.SineOut;
        }
        static object get_SineInOut_3(ref object o)
        {
            return FairyGUI.EaseType.SineInOut;
        }
        static object get_QuadIn_4(ref object o)
        {
            return FairyGUI.EaseType.QuadIn;
        }
        static object get_QuadOut_5(ref object o)
        {
            return FairyGUI.EaseType.QuadOut;
        }
        static object get_QuadInOut_6(ref object o)
        {
            return FairyGUI.EaseType.QuadInOut;
        }
        static object get_CubicIn_7(ref object o)
        {
            return FairyGUI.EaseType.CubicIn;
        }
        static object get_CubicOut_8(ref object o)
        {
            return FairyGUI.EaseType.CubicOut;
        }
        static object get_CubicInOut_9(ref object o)
        {
            return FairyGUI.EaseType.CubicInOut;
        }
        static object get_QuartIn_10(ref object o)
        {
            return FairyGUI.EaseType.QuartIn;
        }
        static object get_QuartOut_11(ref object o)
        {
            return FairyGUI.EaseType.QuartOut;
        }
        static object get_QuartInOut_12(ref object o)
        {
            return FairyGUI.EaseType.QuartInOut;
        }
        static object get_QuintIn_13(ref object o)
        {
            return FairyGUI.EaseType.QuintIn;
        }
        static object get_QuintOut_14(ref object o)
        {
            return FairyGUI.EaseType.QuintOut;
        }
        static object get_QuintInOut_15(ref object o)
        {
            return FairyGUI.EaseType.QuintInOut;
        }
        static object get_ExpoIn_16(ref object o)
        {
            return FairyGUI.EaseType.ExpoIn;
        }
        static object get_ExpoOut_17(ref object o)
        {
            return FairyGUI.EaseType.ExpoOut;
        }
        static object get_ExpoInOut_18(ref object o)
        {
            return FairyGUI.EaseType.ExpoInOut;
        }
        static object get_CircIn_19(ref object o)
        {
            return FairyGUI.EaseType.CircIn;
        }
        static object get_CircOut_20(ref object o)
        {
            return FairyGUI.EaseType.CircOut;
        }
        static object get_CircInOut_21(ref object o)
        {
            return FairyGUI.EaseType.CircInOut;
        }
        static object get_ElasticIn_22(ref object o)
        {
            return FairyGUI.EaseType.ElasticIn;
        }
        static object get_ElasticOut_23(ref object o)
        {
            return FairyGUI.EaseType.ElasticOut;
        }
        static object get_ElasticInOut_24(ref object o)
        {
            return FairyGUI.EaseType.ElasticInOut;
        }
        static object get_BackIn_25(ref object o)
        {
            return FairyGUI.EaseType.BackIn;
        }
        static object get_BackOut_26(ref object o)
        {
            return FairyGUI.EaseType.BackOut;
        }
        static object get_BackInOut_27(ref object o)
        {
            return FairyGUI.EaseType.BackInOut;
        }
        static object get_BounceIn_28(ref object o)
        {
            return FairyGUI.EaseType.BounceIn;
        }
        static object get_BounceOut_29(ref object o)
        {
            return FairyGUI.EaseType.BounceOut;
        }
        static object get_BounceInOut_30(ref object o)
        {
            return FairyGUI.EaseType.BounceInOut;
        }
        static object get_Custom_31(ref object o)
        {
            return FairyGUI.EaseType.Custom;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new FairyGUI.EaseType();
            ins = (FairyGUI.EaseType)o;
            return ins;
        }


    }
}
