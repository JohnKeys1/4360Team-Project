using System;
using System.Collections.Generic;


class InvoiceEntry{
int LineNo;
int Qnty;

// Invoice EntryInvoice;
Item ItemEntry;

public InvoiceEntry(int l, int q, Item i)
    {
        LineNo = l; 
        Qnty = q;
        ItemEntry = i;
    } 
public int getLine(){
    return LineNo;
}
public void setLineNumber(int lineNum){
    LineNo=lineNum;
}
public int getQnty(){
    
    return Qnty;
    
}
public Item getItem()
    {
        return ItemEntry;
    }
}
