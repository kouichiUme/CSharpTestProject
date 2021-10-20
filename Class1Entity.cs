using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;


namespace TestProject1
{
    public class Class1Entity


    {


        public void transaction()
        {
            using (var ts = new TransactionScope())
            {
                    ts.Complete();
            }

        }


    }
}
