using System;

 class Cliente
    {
        
        
        public string nombre;
        private int valormonto;

        public Cliente(string nomb)
        {
            nombre = nomb;
            valormonto = 0;
        }


        public void Ingresardinero(int valor)
        {
            valormonto = +valor;
        }

        public void Retirardinero(int valor)
        {
            //metodo para retirar dinero 
            valormonto = +valor;
        }

        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(" ");
            Console.WriteLine("El nombre del cliente es: " + cliente.nombre);
            Console.WriteLine("El valor del monto del cliente es: " + cliente.valormonto);

            //modificar 
            cliente.Ingresardinero(800);
            Console.WriteLine("El valor del monto del cliente es: " + cliente.valormonto);

            cliente.Retirardinero(58);
            Console.WriteLine("El nombre del cliente es: " + cliente.nombre);
            Console.ReadKey();

        }

        class banco
        {
            Cliente cliente1, cliente2, cliente3;
            private String nombcliente;

            public banco(string nombcliente)
            {
                this.nombcliente = nombcliente;
            }

            public void Cargar()
            {
                string[] nombcliente = new String[3]; //Inicializamos el vector en 3
                for (int f = 1; f < 3; f++)
                {
                    Console.Write("Ingrese el nombre del cliente " + f + ": ");

                    nombcliente[f] = Console.ReadLine(); //Asignamos los 3 nombres al vector
                    Cliente cliente1 = new Cliente(Console.ReadLine());
                }
            }
        }



    }
}
    