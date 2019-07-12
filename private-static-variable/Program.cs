using System;

namespace private_static_variable {

    class Program {

        static void Main(string[] args) {
            var ken = new Customer("Ken");
            var jada = new Customer("Jada");
            Console.WriteLine($"Number of customer instances created is {Customer.InstanceCount}");
        }
    }

    class Customer {

        private static int instanceCount = 0;
        public string Name { get; set; }

        public static int InstanceCount { get { return instanceCount; } }

        public Customer(string name) {
            this.Name = name;
            instanceCount++;
            Console.WriteLine($"Created instance {instanceCount} for customer {name}");
        }
    }
}