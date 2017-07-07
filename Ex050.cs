#define __X86__
#undef OUTPUT_LOG

using System;

//전처리기 지시문(2) (269p)
namespace Ex050
{
    class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_LOG
            Console.WriteLine("OUTPUT_LOG가 정의됨");
#else
            Console.WriteLine("OUTPUT_LOG가 정의되지 않음");
#endif

#if __X86__
            Console.WriteLine("__X86__ 정의됨");
#elif __X64__
            Console.WriteLine("__X64__ 정의됨");
#else
            Console.WriteLine("아무것도 정의되지 않음");
#endif
        }
    }
}