//1. Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes (class GSM holding instances of the classes Battery and Display)/Fields / Defining Simple Classes
//Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null./ constructors
//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

//2.Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null./ constructors

//3.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

//4. Add a method in the GSM class for displaying all information about it. Try to override ToString()./ method 
//5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time./ properties 
//6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//7. Write a class GSMTest to test the GSM class:
    //Create an array of few instances of the GSM class.
    //Display the information about the GSMs in the array.
    //Display the information about the static property IPhone4S.

//8. Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
//9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
//10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
//11. Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

//12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
    //Create an instance of the GSM class.
    //Add few calls.
    //Display the information about the calls.
    //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    //Remove the longest call from the history and calculate the total price again.
    //Finally clear the call history and print it.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClass
{
    class TestGSM
    {
        static void Main()
        {
            GSM[] testArr = new GSM[3];
            GSM nokia = new GSM("Nokia2010", "Nokia", "Gosho", 320);
            GSM samsung = new GSM("Galaxy S2", "Samsung", "Gabriel", 620);
            GSM siemens = new GSM("A2", "Siemens", "Yana", 9);
            testArr[0] = nokia;
            testArr[1] = samsung;
            testArr[2] = siemens;
            for (int i = 0; i < testArr.Length; i++)
            {
                Console.WriteLine(testArr[i]);
            }
            Console.WriteLine(GSM.IPhone4S);

            Call call1 = new Call("21.02.2013", "12:30", "0888 888 888", 58);
            Call call2 = new Call("21.02.2013", "13:30", "0888 888 865", 23);
            Call call3 = new Call("21.02.2013", "12:50", "0888 888 848", 12);
            Call call4 = new Call("21.02.2013", "15:12", "0888 328 888", 135);

            nokia.AddCalls(call1);
            nokia.AddCalls(call2);
            nokia.AddCalls(call3);
            nokia.AddCalls(call4);
            for (int i = 0; i < nokia.CallHistory.Count; i++)
            {
                Console.WriteLine("Call {0}: Date:{1}, Time:{2}, Number:{3}, Duration:{4}",
                    i + 1, nokia.CallHistory[i].Date, nokia.CallHistory[i].Time,
                    nokia.CallHistory[i].DialedPhoneNum, nokia.CallHistory[i].CallDuration);
            }
            Console.WriteLine("Total fee is: {0}", nokia.CalculatePriceForCalls(0.37f));
            nokia.DeleteCalls(3);
            Console.WriteLine("Total fee without the fourth call is: {0}", nokia.CalculatePriceForCalls(0.37f));
            nokia.ClearCallHistory();
            Console.WriteLine("Total fee with cleared call history is: {0}", nokia.CalculatePriceForCalls(0.37f));
        }
    }
}
