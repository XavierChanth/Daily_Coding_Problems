using System;
using System.Threading;
using System.Reflection;

namespace P0010
{
    class FunctionHandler
    {
        int Delay { get; set; }
        string Function { get; set; }
        string[] Args { get; set; }

        public FunctionHandler(int delay, string function, string[] args)
        {
            Delay = delay;
            Function = function;
            Args = args;
        }
        public FunctionHandler(int delay, string function)
        {
            Delay = delay;
            Function = function;
            Args = null;
        }

        public void CallLoadedFunction()
        {
            Type type = this.GetType();
            MethodInfo method = type.GetMethod(this.Function);
            method.Invoke(this, Args);
        }

        public void CallNewFunction(int delay, string function, string[] args)
        {
            new FunctionHandler(delay, function, args);
            Thread.Sleep(delay);
            Console.WriteLine($"Running {function} after {delay} ms...");
            Type type = this.GetType();
            MethodInfo method = type.GetMethod(function);
            method.Invoke(this, args);
        }
        public void CallNewFunction(int delay, string function)
        {
            new FunctionHandler(delay, function);
            Thread.Sleep(delay);
            Console.WriteLine($"Running {function} after {delay} ms...");
            Type type = this.GetType();
            MethodInfo method = type.GetMethod(function);
            method.Invoke(this, null);
        }

    }
}
