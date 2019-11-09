using System;
using System.Collections.Generic;


class Invoice{
    int InvNum;
    string nvDate;

    int total;
    List<Item> items = new List<Item>();
    List<InvoiceEntry> entry = new List<InvoiceEntry>();
    
    public Invoice(int j,string d){
      InvNum=j;
      nvDate=d;
      
     }
   
    public bool addInvEntry(Item i,int ReqQuantity){
  
        if(i.getAvlblQnty() >= ReqQuantity){
            i.updateAvlbQty(ReqQuantity*-1);
            InvoiceEntry x = new InvoiceEntry(entry.Count, ReqQuantity, i);
            entry.Add(x);            
            return true;
        }

        else
        {
            return false;
        }
    }
    public bool removeInvEntry( int l){ 
       InvoiceEntry toRemove = null; 
       foreach(InvoiceEntry i in entry)
        if(i.getLine() == l)
        {
            toRemove= i; 
        }
        entry.Remove(toRemove);

        if(toRemove !=null)
        {
            return true; 
        }
        else
        {
            return false; 
        }
    }
    private void updateTotal(ref int t){
      total +=t;
    }
    public void updateLineNumber(){
      int Counter = 1; // 
        foreach(InvoiceEntry e in entry)
        {
            e.setLineNumber(Counter);
            Counter++;
        }   
    }
    public void printInvoice(){

      Console.WriteLine("Invoice #: " + InvNum + "Date: "+ nvDate);
        Console.WriteLine("{0,4} {1,6} {2,15} {3,6} {4,5}", "Line #", "Ln", "Item", "Price", "Availble Qty" , "Total");
        Console.WriteLine("------    --------------- -------- ----------");
        foreach ( InvoiceEntry e in entry)
        {
            float linetotal = 0;
            linetotal = e.getItem().getPrice() * e.getQnty();
            Console.WriteLine(e.getLine() + "\t" + e.getItem().getItemID() +  "\t" + e.getItem().getItemDescription() +  "\t"   + e.getItem().getPrice() + "\t"  + e.getQnty() +  "\t" + linetotal );
        }
      
    }

    

    
}
