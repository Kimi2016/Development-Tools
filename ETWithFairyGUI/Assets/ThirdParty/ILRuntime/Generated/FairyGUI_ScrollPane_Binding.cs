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
    unsafe class FairyGUI_ScrollPane_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(FairyGUI.ScrollPane);
            args = new Type[]{};
            method = type.GetMethod("get_onScroll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onScroll_0);
            args = new Type[]{};
            method = type.GetMethod("get_onScrollEnd", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onScrollEnd_1);
            args = new Type[]{};
            method = type.GetMethod("get_onPullDownRelease", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onPullDownRelease_2);
            args = new Type[]{};
            method = type.GetMethod("get_onPullUpRelease", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_onPullUpRelease_3);
            args = new Type[]{};
            method = type.GetMethod("get_draggingPane", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_draggingPane_4);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_5);
            args = new Type[]{};
            method = type.GetMethod("get_owner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_owner_6);
            args = new Type[]{};
            method = type.GetMethod("get_hzScrollBar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hzScrollBar_7);
            args = new Type[]{};
            method = type.GetMethod("get_vtScrollBar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vtScrollBar_8);
            args = new Type[]{};
            method = type.GetMethod("get_header", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_header_9);
            args = new Type[]{};
            method = type.GetMethod("get_footer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_footer_10);
            args = new Type[]{};
            method = type.GetMethod("get_bouncebackEffect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bouncebackEffect_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_bouncebackEffect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bouncebackEffect_12);
            args = new Type[]{};
            method = type.GetMethod("get_touchEffect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchEffect_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_touchEffect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_touchEffect_14);
            args = new Type[]{};
            method = type.GetMethod("get_inertiaDisabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inertiaDisabled_15);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_inertiaDisabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_inertiaDisabled_16);
            args = new Type[]{};
            method = type.GetMethod("get_softnessOnTopOrLeftSide", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softnessOnTopOrLeftSide_17);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softnessOnTopOrLeftSide", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softnessOnTopOrLeftSide_18);
            args = new Type[]{};
            method = type.GetMethod("get_scrollStep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scrollStep_19);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_scrollStep", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_scrollStep_20);
            args = new Type[]{};
            method = type.GetMethod("get_snapToItem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_snapToItem_21);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_snapToItem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_snapToItem_22);
            args = new Type[]{};
            method = type.GetMethod("get_pageMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pageMode_23);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_pageMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pageMode_24);
            args = new Type[]{};
            method = type.GetMethod("get_pageController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pageController_25);
            args = new Type[]{typeof(FairyGUI.Controller)};
            method = type.GetMethod("set_pageController", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pageController_26);
            args = new Type[]{};
            method = type.GetMethod("get_mouseWheelEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mouseWheelEnabled_27);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_mouseWheelEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mouseWheelEnabled_28);
            args = new Type[]{};
            method = type.GetMethod("get_decelerationRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_decelerationRate_29);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_decelerationRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_decelerationRate_30);
            args = new Type[]{};
            method = type.GetMethod("get_percX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_percX_31);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_percX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_percX_32);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("SetPercX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPercX_33);
            args = new Type[]{};
            method = type.GetMethod("get_percY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_percY_34);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_percY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_percY_35);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("SetPercY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPercY_36);
            args = new Type[]{};
            method = type.GetMethod("get_posX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_posX_37);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_posX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_posX_38);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("SetPosX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPosX_39);
            args = new Type[]{};
            method = type.GetMethod("get_posY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_posY_40);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_posY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_posY_41);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("SetPosY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPosY_42);
            args = new Type[]{};
            method = type.GetMethod("get_isBottomMost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isBottomMost_43);
            args = new Type[]{};
            method = type.GetMethod("get_isRightMost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isRightMost_44);
            args = new Type[]{};
            method = type.GetMethod("get_currentPageX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentPageX_45);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_currentPageX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_currentPageX_46);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetCurrentPageX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCurrentPageX_47);
            args = new Type[]{};
            method = type.GetMethod("get_currentPageY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentPageY_48);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_currentPageY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_currentPageY_49);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetCurrentPageY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCurrentPageY_50);
            args = new Type[]{};
            method = type.GetMethod("get_scrollingPosX", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scrollingPosX_51);
            args = new Type[]{};
            method = type.GetMethod("get_scrollingPosY", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scrollingPosY_52);
            args = new Type[]{};
            method = type.GetMethod("get_contentWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_contentWidth_53);
            args = new Type[]{};
            method = type.GetMethod("get_contentHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_contentHeight_54);
            args = new Type[]{};
            method = type.GetMethod("get_viewWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_viewWidth_55);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_viewWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_viewWidth_56);
            args = new Type[]{};
            method = type.GetMethod("get_viewHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_viewHeight_57);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_viewHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_viewHeight_58);
            args = new Type[]{};
            method = type.GetMethod("ScrollTop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollTop_59);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ScrollTop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollTop_60);
            args = new Type[]{};
            method = type.GetMethod("ScrollBottom", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollBottom_61);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ScrollBottom", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollBottom_62);
            args = new Type[]{};
            method = type.GetMethod("ScrollUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollUp_63);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("ScrollUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollUp_64);
            args = new Type[]{};
            method = type.GetMethod("ScrollDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollDown_65);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("ScrollDown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollDown_66);
            args = new Type[]{};
            method = type.GetMethod("ScrollLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollLeft_67);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("ScrollLeft", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollLeft_68);
            args = new Type[]{};
            method = type.GetMethod("ScrollRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollRight_69);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetMethod("ScrollRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollRight_70);
            args = new Type[]{typeof(FairyGUI.GObject)};
            method = type.GetMethod("ScrollToView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollToView_71);
            args = new Type[]{typeof(FairyGUI.GObject), typeof(System.Boolean)};
            method = type.GetMethod("ScrollToView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollToView_72);
            args = new Type[]{typeof(FairyGUI.GObject), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("ScrollToView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollToView_73);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("ScrollToView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollToView_74);
            args = new Type[]{typeof(FairyGUI.GObject)};
            method = type.GetMethod("IsChildInView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsChildInView_75);
            args = new Type[]{};
            method = type.GetMethod("CancelDragging", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CancelDragging_76);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("LockHeader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LockHeader_77);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("LockFooter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LockFooter_78);



            app.RegisterCLRCreateArrayInstance(type, s => new FairyGUI.ScrollPane[s]);

            args = new Type[]{typeof(FairyGUI.GComponent), typeof(FairyGUI.ScrollType), typeof(FairyGUI.Margin), typeof(FairyGUI.ScrollBarDisplayType), typeof(System.Int32), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_onScroll_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onScroll;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_onScrollEnd_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onScrollEnd;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_onPullDownRelease_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onPullDownRelease;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_onPullUpRelease_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.onPullUpRelease;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_draggingPane_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = FairyGUI.ScrollPane.draggingPane;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Dispose_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }

        static StackObject* get_owner_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.owner;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hzScrollBar_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hzScrollBar;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_vtScrollBar_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.vtScrollBar;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_header_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.header;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_footer_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.footer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_bouncebackEffect_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bouncebackEffect;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_bouncebackEffect_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bouncebackEffect = value;

            return __ret;
        }

        static StackObject* get_touchEffect_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.touchEffect;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_touchEffect_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.touchEffect = value;

            return __ret;
        }

        static StackObject* get_inertiaDisabled_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inertiaDisabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_inertiaDisabled_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.inertiaDisabled = value;

            return __ret;
        }

        static StackObject* get_softnessOnTopOrLeftSide_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.softnessOnTopOrLeftSide;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softnessOnTopOrLeftSide_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.softnessOnTopOrLeftSide = value;

            return __ret;
        }

        static StackObject* get_scrollStep_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scrollStep;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_scrollStep_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.scrollStep = value;

            return __ret;
        }

        static StackObject* get_snapToItem_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.snapToItem;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_snapToItem_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.snapToItem = value;

            return __ret;
        }

        static StackObject* get_pageMode_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pageMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_pageMode_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pageMode = value;

            return __ret;
        }

        static StackObject* get_pageController_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.pageController;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_pageController_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.Controller @value = (FairyGUI.Controller)typeof(FairyGUI.Controller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.pageController = value;

            return __ret;
        }

        static StackObject* get_mouseWheelEnabled_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mouseWheelEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_mouseWheelEnabled_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mouseWheelEnabled = value;

            return __ret;
        }

        static StackObject* get_decelerationRate_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.decelerationRate;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_decelerationRate_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.decelerationRate = value;

            return __ret;
        }

        static StackObject* get_percX_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.percX;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_percX_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.percX = value;

            return __ret;
        }

        static StackObject* SetPercX_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPercX(@value, @ani);

            return __ret;
        }

        static StackObject* get_percY_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.percY;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_percY_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.percY = value;

            return __ret;
        }

        static StackObject* SetPercY_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPercY(@value, @ani);

            return __ret;
        }

        static StackObject* get_posX_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.posX;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_posX_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.posX = value;

            return __ret;
        }

        static StackObject* SetPosX_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPosX(@value, @ani);

            return __ret;
        }

        static StackObject* get_posY_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.posY;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_posY_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.posY = value;

            return __ret;
        }

        static StackObject* SetPosY_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPosY(@value, @ani);

            return __ret;
        }

        static StackObject* get_isBottomMost_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isBottomMost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isRightMost_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isRightMost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_currentPageX_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentPageX;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_currentPageX_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.currentPageX = value;

            return __ret;
        }

        static StackObject* SetCurrentPageX_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCurrentPageX(@value, @ani);

            return __ret;
        }

        static StackObject* get_currentPageY_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentPageY;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_currentPageY_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.currentPageY = value;

            return __ret;
        }

        static StackObject* SetCurrentPageY_50(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCurrentPageY(@value, @ani);

            return __ret;
        }

        static StackObject* get_scrollingPosX_51(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scrollingPosX;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_scrollingPosY_52(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scrollingPosY;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_contentWidth_53(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.contentWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_contentHeight_54(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.contentHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_viewWidth_55(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.viewWidth;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_viewWidth_56(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.viewWidth = value;

            return __ret;
        }

        static StackObject* get_viewHeight_57(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.viewHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_viewHeight_58(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.viewHeight = value;

            return __ret;
        }

        static StackObject* ScrollTop_59(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollTop();

            return __ret;
        }

        static StackObject* ScrollTop_60(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollTop(@ani);

            return __ret;
        }

        static StackObject* ScrollBottom_61(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollBottom();

            return __ret;
        }

        static StackObject* ScrollBottom_62(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollBottom(@ani);

            return __ret;
        }

        static StackObject* ScrollUp_63(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollUp();

            return __ret;
        }

        static StackObject* ScrollUp_64(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollUp(@ratio, @ani);

            return __ret;
        }

        static StackObject* ScrollDown_65(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollDown();

            return __ret;
        }

        static StackObject* ScrollDown_66(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollDown(@ratio, @ani);

            return __ret;
        }

        static StackObject* ScrollLeft_67(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollLeft();

            return __ret;
        }

        static StackObject* ScrollLeft_68(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollLeft(@ratio, @ani);

            return __ret;
        }

        static StackObject* ScrollRight_69(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollRight();

            return __ret;
        }

        static StackObject* ScrollRight_70(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollRight(@ratio, @ani);

            return __ret;
        }

        static StackObject* ScrollToView_71(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GObject @obj = (FairyGUI.GObject)typeof(FairyGUI.GObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollToView(@obj);

            return __ret;
        }

        static StackObject* ScrollToView_72(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GObject @obj = (FairyGUI.GObject)typeof(FairyGUI.GObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollToView(@obj, @ani);

            return __ret;
        }

        static StackObject* ScrollToView_73(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @setFirst = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            FairyGUI.GObject @obj = (FairyGUI.GObject)typeof(FairyGUI.GObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollToView(@obj, @ani, @setFirst);

            return __ret;
        }

        static StackObject* ScrollToView_74(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @setFirst = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @ani = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollToView(@rect, @ani, @setFirst);

            return __ret;
        }

        static StackObject* IsChildInView_75(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GObject @obj = (FairyGUI.GObject)typeof(FairyGUI.GObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsChildInView(@obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CancelDragging_76(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CancelDragging();

            return __ret;
        }

        static StackObject* LockHeader_77(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LockHeader(@size);

            return __ret;
        }

        static StackObject* LockFooter_78(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.ScrollPane instance_of_this_method = (FairyGUI.ScrollPane)typeof(FairyGUI.ScrollPane).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LockFooter(@size);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @footerRes = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @headerRes = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @hzScrollBarRes = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @vtScrollBarRes = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @flags = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            FairyGUI.ScrollBarDisplayType @scrollBarDisplay = (FairyGUI.ScrollBarDisplayType)typeof(FairyGUI.ScrollBarDisplayType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            FairyGUI.Margin @scrollBarMargin = (FairyGUI.Margin)typeof(FairyGUI.Margin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            FairyGUI.ScrollType @scrollType = (FairyGUI.ScrollType)typeof(FairyGUI.ScrollType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            FairyGUI.GComponent @owner = (FairyGUI.GComponent)typeof(FairyGUI.GComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new FairyGUI.ScrollPane(@owner, @scrollType, @scrollBarMargin, @scrollBarDisplay, @flags, @vtScrollBarRes, @hzScrollBarRes, @headerRes, @footerRes);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
