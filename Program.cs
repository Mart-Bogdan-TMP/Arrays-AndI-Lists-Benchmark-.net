using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdaMicrobenchmarking;

namespace ConsoleApplication1
{
    /// <summary>
    /// Abstract classess are bit faster than interfaces
    /// </summary>
    public abstract class Calculator
    {
        public abstract long CalcSumGen<T>(T list) where T : IList<long>;
        public abstract long CalcSumNonGen(IList<long> list);
        public abstract long CalcSumExact(List<long> list);
        public abstract long CalcSumExact(long[] list);
    }

    public class InlineCountCalculator : Calculator
    {
        public override long CalcSumGen<T>(T list)
        {
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        public override long CalcSumNonGen(IList<long> list)
        {
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        public override long CalcSumExact(List<long> list)
        {
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        public override long CalcSumExact(long[] list)
        {
            long sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }

            return sum;
        }
    }

    public class CachedSizeCalculator : Calculator
    {

        public override long CalcSumGen<T>(T list)
        {
            var count = list.Count;
            long sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        public override long CalcSumNonGen(IList<long> list)
        {
            var count = list.Count;
            long sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
        public override long CalcSumExact(List<long> list)
        {
            var count = list.Count;
            long sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
        public override long CalcSumExact(long[] list)
        {
            var count = list.Length;
            long sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
    }


    public class ForeachCalculator : Calculator
    {
        public override long CalcSumGen<T>(T list)
        {
            long sum = 0;
            foreach (var val in list)
            {
                sum += val;
            }
            return sum;
        }

        public override long CalcSumNonGen(IList<long> list)
        {
            long sum = 0;
            foreach (var val in list)
            {
                sum += val;
            }
            return sum;
        }

        public override long CalcSumExact(List<long> list)
        {
            long sum = 0;
            foreach (var val in list)
            {
                sum += val;
            }
            return sum;
        }

        public override long CalcSumExact(long[] list)
        {
            long sum = 0;
            foreach (var val in list)
            {
                sum += val;
            }
            return sum;
        }
    }

    public class LinqCalculator : Calculator
    {
        public override long CalcSumGen<T>(T list)
        {
            return list.Sum();
        }

        public override long CalcSumNonGen(IList<long> list)
        {
            return list.Sum();
        }

        public override long CalcSumExact(List<long> list)
        {
            return list.Sum();
        }

        public override long CalcSumExact(long[] list)
        {
            return list.Sum();
        }
    }

    class Program
    {
        private const int WarmupIterations = 10;
        private const int ArrSize = 5000000;

        static long[] _array = new long[ArrSize];
        static List<long> _list;

        static void Main(string[] args)
        {
            for (int i = 0; i < ArrSize; i++)
            {
                _array[i] = i;
            }

            _list = new List<long>(_array);

            var testSubjects = new Calculator[]
            {
                new CachedSizeCalculator(), 
                new InlineCountCalculator(), 
                new ForeachCalculator(),
                new LinqCalculator()
            };

            Warmup(testSubjects,_array,_list);

            var script = BuildTestScript(testSubjects);

            script.WithHead();
            script.RunAll();

        }

        private static Script<long> BuildTestScript(Calculator[] calculators)
        {
            Script<long> script = Script.Of("EMPTY",()=>1L);

            foreach (var calculator in calculators)
            {
                //this is needed, as variable used in lambdas would change in foreach
                var calc = calculator;

                var calcName = calculator.GetType().Name.Replace("Calculator", "");

              //  calcName += String.Join("",Enumerable.Repeat(' ',20-calcName.Length));

                script
                    .Of(string.Format("{0,-12}: {1} : {2}", calcName, "Generic", "Array"), () => calc.CalcSumGen(_array))
                    .Of(string.Format("{0,-12}: {1} : {2}", calcName, "Generic", "List"), () => calc.CalcSumGen(_list))
                    .Of(string.Format("{0,-12}: {1} : {2}", calcName, "NonGen ", "Array"), () => calc.CalcSumNonGen(_array))
                    .Of(string.Format("{0,-12}: {1} : {2}", calcName, "NonGen ", "List"), () => calc.CalcSumNonGen(_list))
                    .Of(string.Format("{0,-12}: {1} : {2}", calcName, "Exact  ", "Array"), () => calc.CalcSumExact(_array))
                    .Of(string.Format("{0,-12}: {1} : {2}", calcName, "Exact  ", "List"), () => calc.CalcSumExact(_list))
                    
                    ;
            }

            return script;
        }

        private static void Warmup(Calculator[] testSubjects, long[] array, List<long> list)
        {
            Console.WriteLine("Warming up!..");
            foreach (var calculator in testSubjects)
            {
                for (int i = 0; i < WarmupIterations; i++)
                {
                    calculator.CalcSumExact(array);
                    calculator.CalcSumExact(list);
                    calculator.CalcSumGen(array);
                    calculator.CalcSumGen(list);
                    calculator.CalcSumNonGen(array);
                    calculator.CalcSumNonGen(list);
                }
            }
        }
    }
}
