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


    public void addInvEntry(Item i,ref int ReqQuantity,ref int q){
      if(q==ReqQuantity || q>0){
      items.Add(i);
      }else{
        Console.WriteLine("Required items not available");
      }
    }
    public void removeInvEntry( int l){ 
       Item.LineNo=l;
      if (items.Contains (l)){
        items.Remove(l);
      }

    }
    private void updateTotal(ref int i){

    }
    public void updateLineNumber(){
      
    }
    public void printInvoice(){
      
    }

    

    
}
