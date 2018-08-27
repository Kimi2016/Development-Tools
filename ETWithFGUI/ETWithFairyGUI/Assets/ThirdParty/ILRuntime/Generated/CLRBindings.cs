using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {
        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_Int32_Binding.Register(app);
            System_Single_Binding.Register(app);
            System_Int64_Binding.Register(app);
            System_Object_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Array_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            UnityEngine_Quaternion_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            UnityEngine_Playables_PlayState_Binding.Register(app);
            FairyGUI_EventContext_Binding.Register(app);
            FairyGUI_EventDispatcher_Binding.Register(app);
            FairyGUI_EventListener_Binding.Register(app);
            FairyGUI_InputEvent_Binding.Register(app);
            FairyGUI_DisplayObject_Binding.Register(app);
            FairyGUI_Container_Binding.Register(app);
            FairyGUI_Stage_Binding.Register(app);
            FairyGUI_Controller_Binding.Register(app);
            FairyGUI_GObject_Binding.Register(app);
            FairyGUI_GGraph_Binding.Register(app);
            FairyGUI_GGroup_Binding.Register(app);
            FairyGUI_GImage_Binding.Register(app);
            FairyGUI_GLoader_Binding.Register(app);
            FairyGUI_GMovieClip_Binding.Register(app);
            FairyGUI_TextFormat_Binding.Register(app);
            FairyGUI_GTextField_Binding.Register(app);
            FairyGUI_GRichTextField_Binding.Register(app);
            FairyGUI_GTextInput_Binding.Register(app);
            FairyGUI_GComponent_Binding.Register(app);
            FairyGUI_GList_Binding.Register(app);
            FairyGUI_GRoot_Binding.Register(app);
            FairyGUI_GLabel_Binding.Register(app);
            FairyGUI_GButton_Binding.Register(app);
            FairyGUI_GComboBox_Binding.Register(app);
            FairyGUI_GProgressBar_Binding.Register(app);
            FairyGUI_GSlider_Binding.Register(app);
            FairyGUI_PopupMenu_Binding.Register(app);
            FairyGUI_ScrollPane_Binding.Register(app);
            FairyGUI_Transition_Binding.Register(app);
            FairyGUI_UIPackage_Binding.Register(app);
            FairyGUI_Window_Binding.Register(app);
            FairyGUI_GObjectPool_Binding.Register(app);
            FairyGUI_Relations_Binding.Register(app);
            FairyGUI_RelationType_Binding.Register(app);
            FairyGUI_Timers_Binding.Register(app);
            FairyGUI_GTween_Binding.Register(app);
            FairyGUI_GTweener_Binding.Register(app);
            FairyGUI_EaseType_Binding.Register(app);
            FairyGUI_TweenValue_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
