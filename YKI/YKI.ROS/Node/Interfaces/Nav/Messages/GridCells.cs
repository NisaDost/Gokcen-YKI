//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by ros2cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

#nullable enable

namespace Node.Nav
{
    /// <summary>
    /// An array of cells in a 2D grid
    /// </summary>
    /// <remarks>
    /// Message interface definition for <c>nav_msgs/msg/GridCells</c>.
    /// </remarks>
    [global::Rosidl.Runtime.TypeSupportAttribute("nav_msgs/msg/GridCells")]
    internal unsafe partial class GridCells : global::Rosidl.Runtime.IMessage
    {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static string TypeSupportName => "nav_msgs/msg/GridCells";
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static global::Rosidl.Runtime.TypeSupportHandle GetTypeSupportHandle()
        {
            return new global::Rosidl.Runtime.TypeSupportHandle(_PInvoke(), global::Rosidl.Runtime.HandleType.Message);
            
            [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
            [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_typesupport_c", EntryPoint = "rosidl_typesupport_c__get_message_type_support_handle__nav_msgs__msg__GridCells")]
            static extern nint _PInvoke();
        }
        
        /// <summary>
        /// Create a new instance of <see cref="GridCells"/> with fields initialized to specified values.
        /// </summary>
        /// <param name='header'>
        /// Originally defined as: <c><![CDATA[std_msgs/msg/Header header]]></c>
        /// </param>
        /// <param name='cellWidth'>
        /// Width of each cell
        /// <para>(originally defined as: <c><![CDATA[float32 cell_width]]></c>)</para>
        /// </param>
        /// <param name='cellHeight'>
        /// Height of each cell
        /// <para>(originally defined as: <c><![CDATA[float32 cell_height]]></c>)</para>
        /// </param>
        /// <param name='cells'>
        /// Each cell is represented by the Point at the center of the cell
        /// <para>(originally defined as: <c><![CDATA[geometry_msgs/msg/Point[] cells]]></c>)</para>
        /// </param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public GridCells(
            global::Node.Std.Header? @header = null,
            float @cellWidth = 0f,
            float @cellHeight = 0f,
            global::Node.Geometry.Point[]? @cells = null
        )
        {
            Header = @header ?? new global::Node.Std.Header();
            CellWidth = @cellWidth;
            CellHeight = @cellHeight;
            Cells = @cells ?? global::System.Array.Empty<global::Node.Geometry.Point>();
        }
        
        
        /// <summary>
        /// Create a new instance of <see cref="GridCells"/>, and copy its data from the specified <see cref="Priv"/> structure.
        /// </summary>
        /// <param name="priv">The <see cref="Priv"/> structure to be copied from.</param>
        /// <param name="textEncoding">Text encoding of the strings in the <see cref="Priv"/> structure and its containing structures, if any.</param>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public GridCells(in Priv priv, global::System.Text.Encoding textEncoding)
        {
            this.Header = new global::Node.Std.Header(in priv.Header, textEncoding);
            this.CellWidth = priv.CellWidth;
            this.CellHeight = priv.CellHeight;
        
            this.Cells = new global::Node.Geometry.Point[priv.Cells.Size];
            var Cells_span = priv.Cells.AsSpan();
            for (int __i = 0; __i < this.Cells.Length; __i++)
            {
                this.Cells[__i] = new global::Node.Geometry.Point(in Cells_span[__i], textEncoding);
            }
        }
        
        
        /// <summary>
        /// Originally defined as: <c><![CDATA[std_msgs/msg/Header header]]></c>
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public global::Node.Std.Header Header { get; set; }
        
        /// <summary>
        /// Width of each cell
        /// </summary>
        /// <remarks>
        /// Originally defined as: <c><![CDATA[float32 cell_width]]></c>
        /// </remarks>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public float CellWidth { get; set; }
        
        /// <summary>
        /// Height of each cell
        /// </summary>
        /// <remarks>
        /// Originally defined as: <c><![CDATA[float32 cell_height]]></c>
        /// </remarks>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public float CellHeight { get; set; }
        
        /// <summary>
        /// Each cell is represented by the Point at the center of the cell
        /// </summary>
        /// <remarks>
        /// Originally defined as: <c><![CDATA[geometry_msgs/msg/Point[] cells]]></c>
        /// </remarks>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public global::Node.Geometry.Point[] Cells { get; set; }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public void WriteTo(nint data, global::System.Text.Encoding textEncoding)
        {
            WriteTo(ref global::System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()), textEncoding);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public void WriteTo(ref Priv priv, global::System.Text.Encoding textEncoding)
        {
            this.Header.WriteTo(ref priv.Header, textEncoding);
            priv.CellWidth = this.CellWidth;
            priv.CellHeight = this.CellHeight;
            
            priv.Cells = new global::Node.Geometry.Point.PrivSequence(this.Cells.Length);
            var Cells_span = priv.Cells.AsSpan();
            for (int __i = 0; __i < this.Cells.Length; __i++)
            {
                this.Cells[__i].WriteTo(ref Cells_span[__i], textEncoding);
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static global::Rosidl.Runtime.IMessage CreateFrom(nint data, global::System.Text.Encoding textEncoding)
        {
            return new GridCells(in global::System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()), textEncoding);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static nint UnsafeCreate()
        {
            return new(Priv.Create());
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static void UnsafeDestroy(nint data)
        {
            Priv.Destroy((Priv*)data);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static bool UnsafeInitialize(nint data)
        {
            return Priv.TryInitialize(out System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static void UnsafeFinalize(nint data)
        {
            Priv.Finalize(ref System.Runtime.CompilerServices.Unsafe.AsRef<Priv>(data.ToPointer()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static bool UnsafeInitializeSequence(int size, nint data)
        {
            return PrivSequence.TryInitialize(size, out System.Runtime.CompilerServices.Unsafe.AsRef<PrivSequence>(data.ToPointer()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
        public static void UnsafeFinalizeSequence(nint data)
        {
            PrivSequence.Finalize(ref System.Runtime.CompilerServices.Unsafe.AsRef<PrivSequence>(data.ToPointer()));
        }
        
        /// <summary>
        /// An array of cells in a 2D grid
        /// </summary>
        /// <remarks>
        /// Blittable native structure for <c>nav_msgs/msg/GridCells</c>.
        /// </remarks>
        [global::System.Runtime.InteropServices.StructLayoutAttribute(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Priv : global::System.IEquatable<Priv>, global::System.IDisposable
        {
            /// <summary>
            /// Originally defined as: <c><![CDATA[std_msgs/msg/Header header]]></c>
            /// </summary>
            public global::Node.Std.Header.Priv Header;
            
            /// <summary>
            /// Width of each cell
            /// </summary>
            /// <remarks>
            /// Originally defined as: <c><![CDATA[float32 cell_width]]></c>
            /// </remarks>
            public float CellWidth;
            
            /// <summary>
            /// Height of each cell
            /// </summary>
            /// <remarks>
            /// Originally defined as: <c><![CDATA[float32 cell_height]]></c>
            /// </remarks>
            public float CellHeight;
            
            /// <summary>
            /// Each cell is represented by the Point at the center of the cell
            /// </summary>
            /// <remarks>
            /// Originally defined as: <c><![CDATA[geometry_msgs/msg/Point[] cells]]></c>
            /// </remarks>
            public global::Node.Geometry.Point.PrivSequence Cells;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public Priv()
            {
                ThrowIfNonSuccess(TryInitialize(out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public Priv(Priv src)
                : this(in src)
            {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public Priv(in Priv src)
                : this()
            {
                CopyFrom(in src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public Priv(Priv* src)
                : this()
            {
                CopyFrom(src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void Dispose()
            {
                Finalize(ref this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(Priv src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(in Priv src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(Priv* src)
            {
                fixed (Priv* pThis = &this)
                {
                    ThrowIfNonSuccess(TryCopy(src, pThis));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            private static bool TryCopy(in Priv input, out Priv output)
            {
                fixed (Priv* pInput = &input, pOutput = &output)
                {
                    return TryCopy(pInput, pOutput);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public bool Equals(Priv other)
            {
                return Priv.AreEqual(in other, in this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public override bool Equals(object? obj) => obj is Priv s ? this.Equals(s) : false;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public override int GetHashCode()
            {
                var __hashCode = new global::System.HashCode();
                __hashCode.Add(this.Header);
                __hashCode.Add(this.CellWidth);
                __hashCode.Add(this.CellHeight);
                __hashCode.Add(this.Cells);
                return __hashCode.ToHashCode();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static bool operator ==(Priv lhs, Priv rhs)
            {
                return lhs.Equals(rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static bool operator !=(Priv lhs, Priv rhs)
            {
                return !(lhs == rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static Priv* Create()
            {
                return _PInvoke();
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__create")]
                static extern Priv* _PInvoke();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static void Destroy(Priv* msg)
            {
                _PInvoke(msg);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__destroy")]
                static extern void _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static bool TryInitialize(out Priv msg)
            {
                fixed (Priv* pMsg = &msg)
                {
                    return _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__init")]
                static extern bool _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static void Finalize(ref Priv msg)
            {
                fixed (Priv* pMsg = &msg)
                {
                    _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__fini")]
                static extern void _PInvoke(Priv* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            private static bool AreEqual(in Priv lhs, in Priv rhs)
            {
                fixed (Priv* plhs = &lhs, prhs = &rhs)
                {
                    return _PInvoke(plhs, prhs);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__are_qual")]
                static extern bool _PInvoke(Priv* lhs, Priv* rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            private static bool TryCopy(Priv* input, Priv* output)
            {
                return _PInvoke(input, output);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__copy")]
                static extern bool _PInvoke(Priv* input, Priv* output);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static void ThrowIfNonSuccess(bool ret, [global::System.Runtime.CompilerServices.CallerMemberNameAttribute]
            string caller = "")
            {
                if (!ret)
                {
                    throw new global::Rosidl.Runtime.RosidlException($"An error occurred when calling 'global::Node.Nav.GridCells.Priv.{caller}'.");
                }
            }
        }
        
        /// <summary>
        /// An array of cells in a 2D grid
        /// </summary>
        /// <remarks>
        /// Blittable native sequence structure for <c>nav_msgs/msg/GridCells</c>.
        /// </remarks>
        [global::System.Runtime.InteropServices.StructLayoutAttribute(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct PrivSequence : global::System.IEquatable<PrivSequence>, global::System.IDisposable
        {
            private Priv* __data;
            
            private nuint __size;
            
            private nuint __capacity;
            
            public int Size => (int)__size;
            
            public int Capcacity => (int)__capacity;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public PrivSequence()
                : this(0)
            {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public PrivSequence(int size)
            {
                ThrowIfNonSuccess(TryInitialize(size, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public PrivSequence(PrivSequence src)
                : this(in src)
            {
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public PrivSequence(in PrivSequence src)
                : this()
            {
                CopyFrom(in src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public PrivSequence(PrivSequence* src)
                : this()
            {
                CopyFrom(src); 
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public PrivSequence(System.ReadOnlySpan<Priv> src)
                : this(src.Length)
            {
                src.CopyTo(AsSpan());
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void Dispose()
            {
                Finalize(ref this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public System.Span<Priv> AsSpan()
            {
                return new(__data, Size);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(System.ReadOnlySpan<Priv> src)
            {
                Finalize(ref this);
                ThrowIfNonSuccess(TryInitialize(src.Length, out this));
                src.CopyTo(AsSpan());
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(PrivSequence src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(in PrivSequence src)
            {
                ThrowIfNonSuccess(TryCopy(in src, out this));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public void CopyFrom(PrivSequence* src)
            {
                fixed (PrivSequence* pThis = &this)
                {
                    ThrowIfNonSuccess(TryCopy(src, pThis));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            private static bool TryCopy(in PrivSequence input, out PrivSequence output)
            {
                fixed (PrivSequence* pInput = &input, pOutput = &output)
                {
                    return TryCopy(pInput, pOutput);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public bool Equals(PrivSequence other)
            {
                return PrivSequence.AreEqual(in other, in this);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public override bool Equals(object? obj) => obj is PrivSequence s ? this.Equals(s) : false;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public override int GetHashCode()
            {
                return global::System.HashCode.Combine((nint)__data, __size, __capacity);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static bool operator ==(PrivSequence lhs, PrivSequence rhs)
            {
                return lhs.Equals(rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static bool operator !=(PrivSequence lhs, PrivSequence rhs)
            {
                return !(lhs == rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static PrivSequence* Create()
            {
                return _PInvoke();
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__Sequence__create")]
                static extern PrivSequence* _PInvoke();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static void Destroy(PrivSequence* msg)
            {
                _PInvoke(msg);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__Sequence__destroy")]
                static extern void _PInvoke(PrivSequence* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static bool TryInitialize(int size, out PrivSequence msg)
            {
                fixed (PrivSequence* pMsg = &msg)
                {
                    return _PInvoke(pMsg, (uint)size);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__Sequence__init")]
                static extern bool _PInvoke(PrivSequence* msg, nuint size);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static void Finalize(ref PrivSequence msg)
            {
                fixed (PrivSequence* pMsg = &msg)
                {
                    _PInvoke(pMsg);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__Sequence__fini")]
                static extern void _PInvoke(PrivSequence* msg);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            private static bool AreEqual(in PrivSequence lhs, in PrivSequence rhs)
            {
                fixed (PrivSequence* plhs = &lhs, prhs = &rhs)
                {
                    return _PInvoke(plhs, prhs);
                }
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__Sequence__are_qual")]
                static extern bool _PInvoke(PrivSequence* lhs, PrivSequence* rhs);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            private static bool TryCopy(PrivSequence* input, PrivSequence* output)
            {
                return _PInvoke(input, output);
                
                [global::System.Runtime.InteropServices.SuppressGCTransitionAttribute]
                [global::System.Runtime.InteropServices.DllImportAttribute("nav_msgs__rosidl_generator_c", EntryPoint = "nav_msgs__msg__GridCells__Sequence__copy")]
                static extern bool _PInvoke(PrivSequence* input, PrivSequence* output);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ros2cs", "1.3.2+da40d8cd913b1d7f1523f4fd2ce6a86ea7d47c2e")]
            public static void ThrowIfNonSuccess(bool ret, [global::System.Runtime.CompilerServices.CallerMemberNameAttribute]
            string caller = "")
            {
                if (!ret)
                {
                    throw new global::Rosidl.Runtime.RosidlException($"An error occurred when calling 'global::Node.Nav.GridCells.PrivSequence.{caller}'.");
                }
            }
        }
    }
}
