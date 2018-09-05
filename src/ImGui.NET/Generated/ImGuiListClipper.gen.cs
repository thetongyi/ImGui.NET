using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImGuiListClipper
    {
        public float StartPosY;
        public float ItemsHeight;
        public int ItemsCount;
        public int StepNo;
        public int DisplayStart;
        public int DisplayEnd;
    }
    public unsafe struct ImGuiListClipperPtr
    {
        public ImGuiListClipper* NativePtr { get; }
        public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
        public ref float StartPosY => ref Unsafe.AsRef<float>(&NativePtr->StartPosY);
        public ref float ItemsHeight => ref Unsafe.AsRef<float>(&NativePtr->ItemsHeight);
        public ref int ItemsCount => ref Unsafe.AsRef<int>(&NativePtr->ItemsCount);
        public ref int StepNo => ref Unsafe.AsRef<int>(&NativePtr->StepNo);
        public ref int DisplayStart => ref Unsafe.AsRef<int>(&NativePtr->DisplayStart);
        public ref int DisplayEnd => ref Unsafe.AsRef<int>(&NativePtr->DisplayEnd);
        public void End()
        {
            ImGuiNative.ImGuiListClipper_End(NativePtr);
        }
        public void Begin(int items_count)
        {
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public void Begin(int items_count, float items_height)
        {
            ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
        }
        public bool Step()
        {
            byte ret = ImGuiNative.ImGuiListClipper_Step(NativePtr);
            return ret != 0;
        }
        public void ImGuiListClipper()
        {
            int items_count = -1;
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_ImGuiListClipper(NativePtr, items_count, items_height);
        }
        public void ImGuiListClipper(int items_count)
        {
            float items_height = -1.0f;
            ImGuiNative.ImGuiListClipper_ImGuiListClipper(NativePtr, items_count, items_height);
        }
        public void ImGuiListClipper(int items_count, float items_height)
        {
            ImGuiNative.ImGuiListClipper_ImGuiListClipper(NativePtr, items_count, items_height);
        }
    }
}
