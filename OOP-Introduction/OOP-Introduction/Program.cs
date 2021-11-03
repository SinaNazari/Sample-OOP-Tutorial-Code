using System;
using System.Collections.Generic;

namespace OOP_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var sweep = new Sweepable();
            var gallary = new ArtExhibit();

            var wallart = new Carpet(sweep,gallary);

            foreach (var action in wallart.actions)
            {
                action.Action();
            }
        }
    }

    public class Carpet
    {
        public int Width { get; set; }
        public List<IAction> actions = new List<IAction>();
        public Carpet(params IAction[] actions)
        {
            this.actions.AddRange(actions);
        }
    }

    public interface IAction
    {
        void Action();
    }


    public class Sweepable : IAction
    {
        public void Action()
        {
            this.Sweep();
        }

        void Sweep()
        {
            Console.WriteLine("Sweep");
        }
    }

    public class ArtExhibit : IAction
    {
        public void Action()
        {
            this.Exhibit();
        }

        void Exhibit()
        {
            Console.WriteLine("Exhibit");
        }
    }
}
