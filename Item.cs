using System;
using System.Collections.Generic;
namespace HW4{

class Item{
    int ID;
    string Description;
    float availableQty=>0;
    float UnitPrice;
    //  List<Item> items = new List<Item>();

     public Item(int i,string d,float a,float u){

     }

    public float updateAvlbQty(){
      

        return availableQty;
    }
    public float getPrice(){
      

        return availableQty;
    }
    
    public string getItemDescription(){
      

        return Description;
    }
    public int getItemID(){
      

        return ID;
    }
    public void displayItem(){
      
    }

    
}
}