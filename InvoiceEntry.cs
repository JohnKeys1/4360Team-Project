using System;
using System.Collections.Generic;


class InvoiceEntry{
int LineNo;
int Qnty;
public int getLine(int ln){
    this.LineNo=ln;
    return LineNo;
}
public void setLineNumber(int LineNum){
    LineNum=LineNo;
}
public int getQnty(){
    
    return Qnty;
    
}
}
