//Task01
//Define a class that holds information about a mobile phone device: model, 
//manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
//and display characteristics (size and number of colors). Define 3 separate classes 
//(class GSM holding instances of the classes Battery and Display).


namespace Task
{
  
    using System;
    using System.Collections.Generic;
    class GSM
    {
        //P1
        private string model;
        private string manifacturer;
        private int price;
        private string owner;
        private List<Call> callHistory;

        public static GSM IPhone4S = new GSM("Iphone 4S", "Apple", 1300, "Gosho",
            new Battery("aaaa", 16, 4, BatteriesEnum.NiMH), new Display(22, 4444), new List<Call>());            
         
        
     
        //P2
        public GSM(string modelInput,string manifacturerInput)
        {
            this.Model = modelInput;
            this.Manifacturer = manifacturerInput;            
        }

        public GSM(string modelInput,string manifacturerInput,int priceInput, string ownerInput, 
            Battery battery, Display display,List<Call> callHistory): 
            this(modelInput,manifacturerInput) 
        {           
            this.Price = priceInput;
            this.Owner = ownerInput;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = callHistory;
        }
        //P1
        public Display Display { get; set; }
        public Battery Battery { get; set; }
        
        //P5

       public string Model
       {
           get
           {
               return this.model;
           }
           set
           {
               if (value.Length == 0 || value.Length > 20)
               {
                   throw new ArgumentException("Invalid phone model!");
               }
               this.model=value;
           }
       }

       public string Manifacturer
       {
           get
           {
               return this.manifacturer;
           }
           set
           {
               if (value.Length == 0 || value.Length > 20)
               {
                   throw new ArgumentException("Invalid manifacturer!");
               }
               this.manifacturer = value;
           }
       }
       public int Price
       {
           get
           {
               return this.price;
           }
           set
           {
               if (value<0 || value > 20000)
               {
                   throw new ArgumentException("Invalid price!");
               }
              
               this.price = value;
           }
       }

       public string Owner
       {
           get
           {
               return this.owner;
           }
           set
           {
               if (value.Length == 0 || value.Length > 40)
               {
                   throw new ArgumentException("Invalid owner name!");
               }
               this.owner = value;
           }
       }

        //P4
       public override string ToString()
       {
           return String.Format("Manifacturer: {0}\n" +
           "Model: {1}\n" +
           "Price: {2}\n" +
           "Owner: {3}\n" +
           "{4}\n" +
           "{5}",
           this.Manifacturer, this.Model, this.Price, this.Owner,
           this.Battery.ToString(), this.Display.ToString());
       }

       //P9
       public List<Call> CallHistory
       {
           get
           {
               return this.callHistory;
           }
           set
           {
               this.callHistory = value;
           }
       } 
        
        //P9

       public List<Call> AddCall()
        {
            Console.WriteLine("Number of calls to be added:");
            int number=int.Parse(Console.ReadLine());
            for (int i=0;i<number;i++)
            {
                Console.WriteLine("Enter the date of the call:");
                DateTime dateOfTheCall =DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dialed number:");
                string dialedNumber = Console.ReadLine();
                Console.WriteLine("Enter the duration of the call:");
                double duration=double.Parse(Console.ReadLine());
                Call newCall=new Call(dateOfTheCall,dialedNumber,duration);
                this.CallHistory.Add(newCall);
            }
           return CallHistory;
        }
       public List<Call> RemoveCall(List<Call> callHistory)
       {
          Console.WriteLine("Number of calls for removing:");
           int number = int.Parse(Console.ReadLine());
           for (int i = 0; i < number; i++)
           {
               int remove=int.Parse(Console.ReadLine());
               this.CallHistory.RemoveAt(remove);
           }
           return this.CallHistory;
       }

       public List<Call> ClearAll()
       {           
           this.CallHistory.Clear();           
           return this.CallHistory;
       }

       public double Calculate(double multiplier)
       {
           double totalSum=0;
           for (int i=0;i<callHistory.Count;i++)
           {
               totalSum = callHistory[i].Duration / 60 * multiplier+totalSum;
           }
           return totalSum;
       }

       public void PrintHistory()
       {
           if (this.CallHistory.Count > 0)
           {
               foreach (var call in this.CallHistory)
               {
                   Console.WriteLine(call.ToString());
               }
           }
           else
           {
               Console.WriteLine("History is empty!");
           }
       }

    }
}
