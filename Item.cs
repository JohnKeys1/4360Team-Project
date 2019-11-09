using System;
using System.Collections.Generic;


class Item{
    int ID;
    string Description;
    float availableQty;
    float UnitPrice;
//    Invoice ItemInvoice;

     public Item(int i,string d,float a,float u){
                ID=i;
                Description=d;
                availableQty=a;
                UnitPrice=u;
     }

    public void updateAvlbQty(float q){
       Console.WriteLine("The current available amount amount of " + Description + " is " + availableQty);
     
          availableQty+=q;
          Console.WriteLine("New Quantity is: " + availableQty);
    }
    public float getPrice(){
      

        return UnitPrice;
    }
    
    public string getItemDescription(){
      

        return Description;
    }
    public int getItemID(){
      

        return ID;
    }
    public float getAvlblQnty()
    {
        return availableQty;
    }
    public void displayItem(){
        Console.WriteLine("{0},{1}, {2}",ID,Description,UnitPrice);
      
    }

    
}
