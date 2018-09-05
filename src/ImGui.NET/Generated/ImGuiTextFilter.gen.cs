using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe struct ImGuiTextFilter
    {
        public fixed byte InputBuf[256];
        public ImVector/*<TextRange>*/ Filters;
        public int CountGrep;
    }
    public unsafe struct ImGuiTextFilterPtr
    {
        public ImGuiTextFilter* NativePtr { get; }
        public ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => NativePtr = nativePtr;
        public ref ImVector/*<TextRange>*/ Filters => ref Unsafe.AsRef<ImVector/*<TextRange>*/>(&NativePtr->Filters);
        public ref int CountGrep => ref Unsafe.AsRef<int>(&NativePtr->CountGrep);
        public void Build()
        {
            ImGuiNative.ImGuiTextFilter_Build(NativePtr);
        }
        public bool Draw()
        {
            int label_byteCount = Encoding.UTF8.GetByteCount("Filter(inc,-exc)");
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = "Filter(inc,-exc)")
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, "Filter(inc,-exc)".Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float width = 0.0f;
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            return ret != 0;
        }
        public bool Draw(string label)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            float width = 0.0f;
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            return ret != 0;
        }
        public bool Draw(string label, float width)
        {
            int label_byteCount = Encoding.UTF8.GetByteCount(label);
            byte* native_label = stackalloc byte[label_byteCount + 1];
            fixed (char* label_ptr = label)
            {
                int native_label_offset = Encoding.UTF8.GetBytes(label_ptr, label.Length, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            byte ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
            return ret != 0;
        }
        public void ImGuiTextFilter()
        {
            int default_filter_byteCount = Encoding.UTF8.GetByteCount("");
            byte* native_default_filter = stackalloc byte[default_filter_byteCount + 1];
            fixed (char* default_filter_ptr = "")
            {
                int native_default_filter_offset = Encoding.UTF8.GetBytes(default_filter_ptr, "".Length, native_default_filter, default_filter_byteCount);
                native_default_filter[native_default_filter_offset] = 0;
            }
            ImGuiNative.ImGuiTextFilter_ImGuiTextFilter(NativePtr, native_default_filter);
        }
        public void ImGuiTextFilter(string default_filter)
        {
            int default_filter_byteCount = Encoding.UTF8.GetByteCount(default_filter);
            byte* native_default_filter = stackalloc byte[default_filter_byteCount + 1];
            fixed (char* default_filter_ptr = default_filter)
            {
                int native_default_filter_offset = Encoding.UTF8.GetBytes(default_filter_ptr, default_filter.Length, native_default_filter, default_filter_byteCount);
                native_default_filter[native_default_filter_offset] = 0;
            }
            ImGuiNative.ImGuiTextFilter_ImGuiTextFilter(NativePtr, native_default_filter);
        }
        public bool IsActive()
        {
            byte ret = ImGuiNative.ImGuiTextFilter_IsActive(NativePtr);
            return ret != 0;
        }
        public void Clear()
        {
            ImGuiNative.ImGuiTextFilter_Clear(NativePtr);
        }
        public bool PassFilter(string text)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            byte* native_text_end = null;
            byte ret = ImGuiNative.ImGuiTextFilter_PassFilter(NativePtr, native_text, native_text_end);
            return ret != 0;
        }
        public bool PassFilter(string text, string text_end)
        {
            int text_byteCount = Encoding.UTF8.GetByteCount(text);
            byte* native_text = stackalloc byte[text_byteCount + 1];
            fixed (char* text_ptr = text)
            {
                int native_text_offset = Encoding.UTF8.GetBytes(text_ptr, text.Length, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            int text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
            byte* native_text_end = stackalloc byte[text_end_byteCount + 1];
            fixed (char* text_end_ptr = text_end)
            {
                int native_text_end_offset = Encoding.UTF8.GetBytes(text_end_ptr, text_end.Length, native_text_end, text_end_byteCount);
                native_text_end[native_text_end_offset] = 0;
            }
            byte ret = ImGuiNative.ImGuiTextFilter_PassFilter(NativePtr, native_text, native_text_end);
            return ret != 0;
        }
    }
}
