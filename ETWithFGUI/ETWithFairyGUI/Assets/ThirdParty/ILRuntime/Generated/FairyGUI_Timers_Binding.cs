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
    unsafe class FairyGUI_Timers_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.Timers);
            args = new Type[]{};
            method = type.GetMethod("get_inst", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inst_0);
            args = new Type[]{typeof(System.Single), typeof(System.Int32), typeof(FairyGUI.TimerCallback)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_1);
            args = new Type[]{typeof(System.Single), typeof(System.Int32), typeof(FairyGUI.TimerCallback), typeof(System.Object)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_2);
            args = new Type[]{typeof(FairyGUI.TimerCallback)};
            method = type.GetMethod("CallLater", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CallLater_3);
            args = new Type[]{typeof(FairyGUI.TimerCallback), typeof(System.Object)};
            method = type.GetMethod("CallLater", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CallLater_4);
            args = new Type[]{typeof(FairyGUI.TimerCallback)};
            method = type.GetMethod("AddUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddUpdate_5);
            args = new Type[]{typeof(FairyGUI.TimerCallback), typeof(System.Object)};
            method = type.GetMethod("AddUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddUpdate_6);
            args = new Type[]{typeof(System.Collections.IEnumerator)};
            method = type.GetMethod("StartCoroutine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartCoroutine_7);
            args = new Type[]{typeof(FairyGUI.TimerCallback)};
            method = type.GetMethod("Exists", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Exists_8);
            args = new Type[]{typeof(FairyGUI.TimerCallback)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_9);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_10);

            field = type.GetField("repeat", flag);
            app.RegisterCLRFieldGetter(field, get_repeat_0);
            app.RegisterCLRFieldSetter(field, set_repeat_0);
            field = type.GetField("time", flag);
            app.RegisterCLRFieldGetter(field, get_time_1);
            app.RegisterCLRFieldSetter(field, set_time_1);
            field = type.GetField("catchCallbackExceptions", flag);
            app.RegisterCLRFieldGetter(field, get_catchCallbackExceptions_2);
            app.RegisterCLRFieldSetter(field, set_catchCallbackExceptions_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new FairyGUI.Timers());
            app.RegisterCLRCreateArrayInstance(type, s => new FairyGUI.Timers[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_inst_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = FairyGUI.Timers.inst;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Add_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @repeat = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @interval = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(@interval, @repeat, @callback);

            return __ret;
        }

        static StackObject* Add_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @callbackParam = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @repeat = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @interval = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(@interval, @repeat, @callback, @callbackParam);

            return __ret;
        }

        static StackObject* CallLater_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CallLater(@callback);

            return __ret;
        }

        static StackObject* CallLater_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @callbackParam = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CallLater(@callback, @callbackParam);

            return __ret;
        }

        static StackObject* AddUpdate_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddUpdate(@callback);

            return __ret;
        }

        static StackObject* AddUpdate_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @callbackParam = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddUpdate(@callback, @callbackParam);

            return __ret;
        }

        static StackObject* StartCoroutine_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.IEnumerator @routine = (System.Collections.IEnumerator)typeof(System.Collections.IEnumerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartCoroutine(@routine);

            return __ret;
        }

        static StackObject* Exists_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Exists(@callback);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Remove_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.TimerCallback @callback = (FairyGUI.TimerCallback)typeof(FairyGUI.TimerCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Remove(@callback);

            return __ret;
        }

        static StackObject* Update_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.Timers instance_of_this_method = (FairyGUI.Timers)typeof(FairyGUI.Timers).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }


        static object get_repeat_0(ref object o)
        {
            return FairyGUI.Timers.repeat;
        }
        static void set_repeat_0(ref object o, object v)
        {
            FairyGUI.Timers.repeat = (System.Int32)v;
        }
        static object get_time_1(ref object o)
        {
            return FairyGUI.Timers.time;
        }
        static void set_time_1(ref object o, object v)
        {
            FairyGUI.Timers.time = (System.Single)v;
        }
        static object get_catchCallbackExceptions_2(ref object o)
        {
            return FairyGUI.Timers.catchCallbackExceptions;
        }
        static void set_catchCallbackExceptions_2(ref object o, object v)
        {
            FairyGUI.Timers.catchCallbackExceptions = (System.Boolean)v;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new FairyGUI.Timers();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
