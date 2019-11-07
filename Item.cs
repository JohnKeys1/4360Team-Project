using System;
using System.Collections.Generic;


class Item{
    int ID;
    string Description;
    float availableQty;
    float UnitPrice;
    //  List<Item> items = new List<Item>();

     public Item(int i,string d,float a,float u){
                ID=i;
                Description=d;
                availableQty=a;
                UnitPrice=u;
     }

    public float updateAvlbQty(ref int q){
      int Qnty=q;
      if(availableQty==0 || availableQty>0){
          availableQty+=q;

      }else{
          Console.WriteLine("available quantity must be greater or equal to 0");
      }
      

        return availableQty;
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
    public void displayItem(){
        Console.WriteLine("{0},{1}",ID,Description);
      
    }

    
}
