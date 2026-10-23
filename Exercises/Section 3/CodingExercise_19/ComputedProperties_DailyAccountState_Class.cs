using System;

namespace Coding.Exercise
{
    public class DailyAccountState
    {
        public int InitialState { get; }
        
        public int SumOfOperations { get;}
        
        public DailyAccountState(
            int initialState, 
            int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }

        private DateTime Date = DateTime.Now;
        
        public int EndOfDayState => InitialState + SumOfOperations;
        public string Report => $"Day: {Date.Day}, month: {Date.Month}, year: {Date.Year}, " +
                                $"initial state: {InitialState}, end of day state: {EndOfDayState}";
    }
}