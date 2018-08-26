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
    unsafe class UnityEngine_Playables_PlayState_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Playables.PlayState);

            field = type.GetField("Paused", flag);
            app.RegisterCLRFieldGetter(field, get_Paused_0);
            field = type.GetField("Playing", flag);
            app.RegisterCLRFieldGetter(field, get_Playing_1);
            field = type.GetField("Delayed", flag);
            app.RegisterCLRFieldGetter(field, get_Delayed_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Playables.PlayState());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Playables.PlayState[s]);


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.Playables.PlayState instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Playables.PlayState[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Paused_0(ref object o)
        {
            return UnityEngine.Playables.PlayState.Paused;
        }
        static object get_Playing_1(ref object o)
        {
            return UnityEngine.Playables.PlayState.Playing;
        }
        static object get_Delayed_2(ref object o)
        {
            return UnityEngine.Playables.PlayState.Delayed;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Playables.PlayState();
            ins = (UnityEngine.Playables.PlayState)o;
            return ins;
        }


    }
}
