﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using GreyMagic;

namespace HearthstoneBot
{
    class Class276
    {
        internal readonly ExternalProcessMemory externalProcessMemory_0;

        private readonly Dictionary<Type, IntPtr> dictionary_0 = new Dictionary<Type, IntPtr>();

        /// <summary>
        /// mono.dll
        /// </summary>
        private readonly IntPtr intptr_0;

        /// <summary>
        /// mono_class_get
        /// </summary>
        internal readonly IntPtr intptr_1;

        // Token: 0x04000D4D RID: 3405
        /// <summary>
        /// mono_class_get_name
        /// </summary>
        private readonly IntPtr intptr_2;

        // Token: 0x04000D4E RID: 3406
        /// <summary>
        /// mono_class_get_namespace
        /// </summary>
        private readonly IntPtr intptr_3;

        // Token: 0x04000D4F RID: 3407
        /// <summary>
        /// mono_assembly_get_image
        /// </summary>
        private readonly IntPtr intptr_4;

        // Token: 0x04000D50 RID: 3408
        private readonly IntPtr intptr_5;

        // Token: 0x04000D51 RID: 3409
        /// <summary>
        /// mono_assembly_open
        /// </summary>
        private readonly IntPtr intptr_6;

        // Token: 0x04000D52 RID: 3410
        private readonly IntPtr intptr_7;

        // Token: 0x04000D53 RID: 3411
        /// <summary>
        /// mono_class_get_fields
        /// </summary>
        private readonly IntPtr intptr_8;

        // Token: 0x04000D54 RID: 3412
        /// <summary>
        /// mono_domain_get
        /// </summary>
        private readonly IntPtr intptr_9;

        // Token: 0x04000D55 RID: 3413
        /// <summary>
        /// mono_gchandle_free
        /// </summary>
        private readonly IntPtr intptr_10;

        // Token: 0x04000D56 RID: 3414
        /// <summary>
        /// mono_field_get_value_object
        /// </summary>
        private readonly IntPtr intptr_11;

        // Token: 0x04000D57 RID: 3415
        private readonly IntPtr intptr_12;

        // Token: 0x04000D58 RID: 3416
        private readonly IntPtr intptr_13;

        // Token: 0x04000D59 RID: 3417
        /// <summary>
        /// mono_image_get_table_rows
        /// </summary>
        internal readonly IntPtr intptr_14;

        // Token: 0x04000D5A RID: 3418
        private readonly IntPtr intptr_15;

        // Token: 0x04000D5B RID: 3419
        /// <summary>
        /// mono_class_get_type
        /// </summary>
        private readonly IntPtr intptr_16;

        // Token: 0x04000D5C RID: 3420
        private readonly IntPtr intptr_17;

        // Token: 0x04000D5D RID: 3421
        private readonly IntPtr intptr_18;

        // Token: 0x04000D5E RID: 3422
        private readonly IntPtr intptr_19;

        // Token: 0x04000D5F RID: 3423
        /// <summary>
        /// mono_class_get_nesting_type
        /// </summary>
        private readonly IntPtr intptr_20;

        // Token: 0x04000D60 RID: 3424
        private readonly IntPtr intptr_21;

        // Token: 0x04000D61 RID: 3425
        /// <summary>
        /// mono_object_unbox
        /// </summary>
        private readonly IntPtr intptr_22;

        // Token: 0x04000D62 RID: 3426
        private readonly IntPtr intptr_23;

        // Token: 0x04000D63 RID: 3427
        private readonly IntPtr intptr_24;

        // Token: 0x04000D64 RID: 3428
        private readonly IntPtr intptr_25;

        // Token: 0x04000D65 RID: 3429
        private readonly IntPtr intptr_26;

        // Token: 0x04000D66 RID: 3430
        /// <summary>
        /// mono_thread_current
        /// </summary>
        private readonly IntPtr intptr_27;

        // Token: 0x04000D67 RID: 3431
        /// <summary>
        /// mono_class_get_parent
        /// </summary>
        private readonly IntPtr intptr_28;

        // Token: 0x04000D68 RID: 3432
        /// <summary>
        /// mono_get_root_domain
        /// </summary>
        private readonly IntPtr intptr_29;

        // Token: 0x04000D69 RID: 3433
        /// <summary>
        /// 16635 - mono_event_get_name
        /// 16635 - mono_field_get_name
        /// 16635 - mono_method_get_token
        /// 16635 - mono_property_get_name
        /// </summary>
        private readonly IntPtr intptr_30;

        // Token: 0x04000D6A RID: 3434
        /// <summary>
        /// mono_thread_attach
        /// </summary>
        private readonly IntPtr intptr_31;

        // Token: 0x04000D6B RID: 3435
        private readonly IntPtr intptr_32;

        // Token: 0x04000D6C RID: 3436
        /// <summary>
        /// mono_thread_get_main
        /// </summary>
        private readonly IntPtr intptr_33;

        // Token: 0x04000D6D RID: 3437
        private readonly IntPtr intptr_34;

        // Token: 0x04000D6E RID: 3438
        private readonly IntPtr intptr_35;

        // Token: 0x04000D6F RID: 3439
        private readonly IntPtr intptr_36;

        internal Class276(ExternalProcessMemory memory)
        {
            externalProcessMemory_0 = memory;
            intptr_0 = method_18("mono.dll");
            intptr_1 = intptr_0 + 0x19319;
            intptr_2 = intptr_0 + 0x166FF;
            intptr_3 = intptr_0 + 0x1670A;
            intptr_4 = intptr_0 + 0x12EBD;
            intptr_5 = intptr_0 + 0x1D840;
            intptr_6 = intptr_0 + 0x1345D;
            intptr_7 = intptr_0 + 0x12099;
            intptr_8 = intptr_0 + 0x1A452;
            intptr_9 = intptr_0 + 0x27D50;
            intptr_10 = intptr_0 + 0x2B649;
            intptr_11 = intptr_0 + 0x6268D;
            intptr_12 = intptr_0 + 0x2B41A;
            intptr_13 = intptr_0 + 0x377BC;
            intptr_14 = intptr_0 + 0x372D7;
            intptr_15 = intptr_0 + 0x388AC;
            intptr_16 = intptr_0 + 0x16715;
            intptr_17 = intptr_0 + 0x80970;
            intptr_18 = intptr_0 + 0x7FE70;
            intptr_19 = intptr_0 + 0x1D783;
            intptr_20 = intptr_0 + 0x372B1;
            intptr_21 = intptr_0 + 0x1678C;
            intptr_22 = intptr_0 + 0x5E694;
            intptr_23 = intptr_0 + 0x68E78;
            intptr_24 = intptr_0 + 0x5E638;
            intptr_25 = intptr_0 + 0x5F5CF;
            intptr_26 = intptr_0 + 0x5DD23;
            intptr_27 = intptr_0 + 0x7E537;
            intptr_28 = intptr_0 + 0x166DD;
            intptr_29 = intptr_0 + 0x27D4A;
            intptr_30 = intptr_0 + 0x16781;
            intptr_31 = intptr_0 + 0x7FCFD;
            intptr_32 = intptr_0 + 0x5F6AD;
            intptr_33 = intptr_0 + 0x5CC9C;
            intptr_34 = intptr_0 + 0x5E197;
            intptr_35 = intptr_0 + 0x165F5;
            intptr_36 = intptr_0 + 0x5DB53;

            method_15<bool>("boolean");
            method_15<object>("object");
            method_15<sbyte>("sbyte");
            method_15<byte>("byte");
            method_15<short>("int16");
            method_15<ushort>("uint16");
            method_15<int>("int32");
            method_15<uint>("uint32");
            method_15<long>("int64");
            method_15<ulong>("uint64");
            method_15<float>("single");
            method_15<double>("double");
            method_15<char>("char");
            method_15<string>("string");
            method_15<Enum>("enum");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="libraryName">mono.dll</param>
        /// <returns></returns>
        internal IntPtr method_18(string libraryName)
        {
            IntPtr procAddress = externalProcessMemory_0.GetProcAddress("kernel32.dll", "GetModuleHandleW");
            IntPtr result;
            var length = libraryName.Length * 2 + 2;
            using (AllocatedMemory allocatedMemory = externalProcessMemory_0.CreateAllocatedMemory(length))
            {
                allocatedMemory.WriteString(0, libraryName, Encoding.Unicode);
                result = externalProcessMemory_0.CallInjected<IntPtr>(procAddress, CallingConvention.StdCall, allocatedMemory.Address);
            }
            return result;
        }

        private void method_15<T>(string string_0)
        {
            var ptr1 = method_19($"mono_get_{string_0}_class");
            var ptr2 = method_17<IntPtr>(ptr1, Array.Empty<object>());
            dictionary_0.Add(typeof(T), ptr2);
        }

        internal T method_17<T>(IntPtr intptr_37, params object[] object_0) where T : struct
        {
            return externalProcessMemory_0.CallInjected<T>(intptr_37, CallingConvention.Cdecl, object_0);
        }

        internal IntPtr method_19(string string_0)
        {
            IntPtr procAddress = externalProcessMemory_0.GetProcAddress("kernel32.dll", "GetProcAddress");
            IntPtr result;
            var length = string_0.Length + 1;
            using (AllocatedMemory allocatedMemory = externalProcessMemory_0.CreateAllocatedMemory(length))
            {
                allocatedMemory.WriteString(0, string_0, Encoding.ASCII);
                result = externalProcessMemory_0.CallInjected<IntPtr>(procAddress, CallingConvention.StdCall, intptr_0, allocatedMemory.Address);
            }
            return result;
        }

        /// <summary>
        /// mono_thread_attach
        /// </summary>
        /// <returns></returns>
        internal IntPtr method_2()
        {
            var ptr = method_4();//mono_get_root_domain
            return method_17<IntPtr>(intptr_31, ptr);//mono_thread_attach
        }

        /// <summary>
        /// mono_get_root_domain
        /// </summary>
        /// <returns></returns>
        internal IntPtr method_4()
        {
            return method_17<IntPtr>(intptr_29, Array.Empty<object>());//mono_get_root_domain
        }

        /// <summary>
        /// mono_field_get_value_object
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <param name="intptr_38"></param>
        /// <returns></returns>
        internal IntPtr method_22(IntPtr intptr_37, IntPtr intptr_38)
        {
            IntPtr intPtr = this.method_27();//mono_domain_get
           
            var array = new object[]
            {
                intPtr,
                intptr_38,
                intptr_37
            };

            return this.method_17<IntPtr>(this.intptr_11, array);//mono_field_get_value_object
        }

        /// <summary>
        /// mono_object_unbox
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal IntPtr method_26(IntPtr intptr_37)
        {
            var array = new object[]
            {
                intptr_37
            };

            return this.method_17<IntPtr>(this.intptr_22, array); //mono_object_unbox
        }

        /// <summary>
        /// mono_domain_get
        /// </summary>
        /// <returns></returns>
        internal IntPtr method_27()
        {
            return this.method_17<IntPtr>(this.intptr_9, Array.Empty<object>());//mono_domain_get
        }

        internal Dictionary<string, IntPtr> method_20(string string_0, ref Dictionary<string, IntPtr> dictionary_1)
        {
            Dictionary<string, IntPtr> dictionary = new Dictionary<string, IntPtr>();
            IntPtr value = this.method_29();//mono_thread_get_main
            IntPtr intPtr = this.method_30();//mono_thread_current
            //value != intPtr;
            if (intPtr == IntPtr.Zero)
            {
                throw new Exception("Code is not running on a mono thread!");
            }
            int num;
            IntPtr intptr_ = this.method_40(string_0, out num);
            this.method_16(intptr_, "Could not load assembly. Status: " + num);
            IntPtr intptr_2 = this.method_39(intptr_);
            this.method_16(intptr_2, "Could not open mono image. Status: " + num);
            var class277 = method_44(intptr_2);
            foreach (IntPtr intPtr2 in class277)
            {
                if (intPtr2 != IntPtr.Zero)
                {
                    this.externalProcessMemory_0.Read<Struct111>(intPtr2);
                    IntPtr intPtr3 = this.method_14(intPtr2);//mono_class_get_nesting_type
                    string text = this.method_45(intPtr2);//mono_class_get_name
                    if (intPtr3 != IntPtr.Zero)
                    {
                        text = this.method_44(intPtr3) + "." + text;
                    }
                    string text2 = this.method_46(intPtr2);//mono_class_get_namespace
                    if (!dictionary.ContainsKey(string.Concat(new string[]
                    {
                        string_0,
                        "~",
                        text2,
                        ".",
                        text
                    })))
                    {
                        string key = string.Concat(new string[]
                        {
                            string_0,
                            "~",
                            text2,
                            ".",
                            text
                        });
                        dictionary.Add(key, intPtr2);
                        dictionary_1.Add(key, this.method_12(intPtr2));
                    }
                }
            }
            return dictionary;
        }

        /// <summary>
        /// mono_thread_get_main
        /// </summary>
        /// <returns></returns>
        internal IntPtr method_29()
        {
            return this.method_17<IntPtr>(this.intptr_33, Array.Empty<object>());//mono_thread_get_main
        }

        /// <summary>
        /// mono_thread_current
        /// </summary>
        /// <returns></returns>
        internal IntPtr method_30()
        {
            return this.method_17<IntPtr>(this.intptr_27, Array.Empty<object>());//mono_thread_current
        }

        /// <summary>
        /// mono_assembly_get_image
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal IntPtr method_39(IntPtr intptr_37)
        {
            return this.method_17<IntPtr>(this.intptr_4,//mono_assembly_get_image
                new object[]
            {
                intptr_37
            });
        }

        /// <summary>
        /// mono_assembly_open
        /// </summary>
        /// <param name="string_0"></param>
        /// <param name="int_0"></param>
        /// <returns></returns>
        internal IntPtr method_40(string string_0, out int int_0)
        {
            IntPtr result;
            using (AllocatedMemory allocatedMemory = this.externalProcessMemory_0.CreateAllocatedMemory(string_0.Length * 2 + 2 + 4))
            {
                allocatedMemory.WriteString(4, string_0, Encoding.UTF8);
                IntPtr intPtr = this.method_17<IntPtr>(this.intptr_6, //mono_assembly_open
                    new object[]
                {
                    allocatedMemory.Address + 4,
                    allocatedMemory.Address
                });
                int_0 = allocatedMemory.Read<int>(0);
                result = intPtr;
            }
            return result;
        }

        private void method_16(IntPtr intptr_37, string string_0)
        {
            if (intptr_37 == IntPtr.Zero)
            {
                throw new Exception(string_0);
            }
        }

        internal IEnumerable<IntPtr> method_44(IntPtr intptr_37)
        {
            Class277 @class = new Class277(-2);
            @class.class276_0 = this;
            @class.intptr_2 = intptr_37;
            return @class;
        }

        /// <summary>
        /// mono_class_get_nesting_type
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal IntPtr method_14(IntPtr intptr_37)
        {
            return this.method_17<IntPtr>(this.intptr_20,//mono_class_get_nesting_type
                new object[]
            {
                intptr_37
            });
        }

        /// <summary>
        /// mono_class_get_name
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal string method_45(IntPtr intptr_37)
        {
            IntPtr intPtr = this.method_14(intptr_37);//mono_class_get_nesting_type
            string text = "";
            while (intPtr != IntPtr.Zero)
            {
                text = this.method_45(intPtr) + "." + text;
                intPtr = this.method_14(intPtr);
            }

            var ptr = this.method_17<IntPtr>(this.intptr_2,//mono_class_get_name 
                new object[]
            {
                intptr_37
            });
            return text + this.externalProcessMemory_0.ReadStringA(ptr);
        }

        /// <summary>
        /// mono_class_get_namespace
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal string method_46(IntPtr intptr_37)
        {
            var ptr = this.method_17<IntPtr>(this.intptr_3,//mono_class_get_namespace
                new object[]
            {
                intptr_37
            });
            return this.externalProcessMemory_0.ReadStringA(ptr);
        }

        /// <summary>
        /// mono_class_get_type
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal IntPtr method_12(IntPtr intptr_37)
        {
            var array = new object[]
            {
                intptr_37
            };
            return this.method_17<IntPtr>(this.intptr_16, array);//mono_class_get_type
        }

        internal IntPtr method_34(IntPtr intptr_37, string string_0)
        {
            while (intptr_37 != IntPtr.Zero)
            {
                using (AllocatedMemory allocatedMemory = this.externalProcessMemory_0.CreateAllocatedMemory(256))
                {
                    allocatedMemory.AllocateOfChunk<IntPtr>("Itr");
                    IntPtr intPtr;
                    while ((intPtr = this.method_36(intptr_37, allocatedMemory["Itr"])) != IntPtr.Zero)//mono_class_get_fields
                    {
                        IntPtr address = this.method_38(intPtr);
                        if (this.externalProcessMemory_0.ReadStringA(address) == string_0)
                        {
                            return intPtr;
                        }
                    }
                }
                intptr_37 = this.method_25(intptr_37);
            }
            return IntPtr.Zero;
        }

        /// <summary>
        /// mono_class_get_fields
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <param name="intptr_38"></param>
        /// <returns></returns>
        internal IntPtr method_36(IntPtr intptr_37, IntPtr intptr_38)
        {
            return this.method_17<IntPtr>(this.intptr_8,//mono_class_get_fields
                new object[]
            {
                intptr_37,
                intptr_38
            });
        }

        /// <summary>
        /// field(property) get name
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal IntPtr method_38(IntPtr intptr_37)
        {
            return this.method_17<IntPtr>(this.intptr_30, new object[]
            {
                intptr_37
            });
        }

        /// <summary>
        /// mono_class_get_parent
        /// </summary>
        /// <param name="intptr_37"></param>
        /// <returns></returns>
        internal IntPtr method_25(IntPtr intptr_37)
        {
            return this.method_17<IntPtr>(this.intptr_28, new object[]
            {
                intptr_37
            });
        }

        internal IntPtr method_21(string string_0, string string_1, string string_2)
        {
            IntPtr value = this.method_29();//mono_thread_get_main
            IntPtr intPtr = this.method_30();//mono_thread_current
            //value != intPtr;
            if (intPtr == IntPtr.Zero)
            {
                throw new Exception("Code is not running on a mono thread!");
            }
            int num;
            IntPtr intptr_ = this.method_40(string_0, out num);
            this.method_16(intptr_, "Could not load assembly. Status: " + num);
            IntPtr intptr_2 = this.method_39(intptr_);
            this.method_16(intptr_2, "Could not open mono image. Status: " + num);
            using (IEnumerator<IntPtr> enumerator = this.method_44(intptr_2).GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    IntPtr intPtr2 = enumerator.Current;
                    if (intPtr2 != IntPtr.Zero)
                    {
                        string a = this.method_45(intPtr2);//get class name
                        string a2 = this.method_46(intPtr2);//get class namespace
                        if (a == string_2 && a2 == string_1)
                        {
                            return intPtr2;
                        }
                    }
                }
            }
            Debugger.Break();
            return IntPtr.Zero;
        }

        /// <summary>
        /// mono_gchandle_free
        /// </summary>
        /// <param name="uint_0"></param>
        internal void method_11(uint uint_0)
        {
            this.method_17<int>(this.intptr_10,//mono_gchandle_free
                new object[]
            {
                uint_0
            });
        }
    }
}
