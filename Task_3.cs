using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tasks
{
    public class Task_3
    {
        private class RailwayTransport
        {
            private ArrayList carrigeList;

            internal class Carrige : IComparable<Carrige>
            {
                private int index;
                private int comfortLevel;
                private int baggageWeight;
                private int passengerCount { get; }

                public int PassengerCount()
                {
                    return passengerCount;
                }

                public int CompareTo(Carrige other)
                {
                    if (ReferenceEquals(this, other)) return 0;
                    if (ReferenceEquals(null, other)) return 1;
                    return comfortLevel.CompareTo(other.comfortLevel);
                }
            }


            public ArrayList SortByComfort()
            {
                ArrayList resultList = carrigeList;
                resultList.Sort();
                return resultList;
            }

            public ArrayList GetCarrigeInsideDiap(int floor, int ceil)
            {
                ArrayList resultList = new ArrayList();
                foreach (Carrige c in carrigeList)
                {
                    if (c.PassengerCount() >= floor && c.PassengerCount() <= ceil)
                    {
                        resultList.Add(c);
                    }
                }

                return resultList;
            }
        }
    }
}