interface documents{
    String document(); 
}

class WordDocument implements documents{
    @Override
    public String document(){
        return "It is a WordDocument";
    }
}

class PdfDocument implements documents{
    @Override
    public String document(){
        return "It is a PdfDocument";
    }
}

class ExcelDocument implements documents{
    @Override
    public String document(){
        return "It is a ExcelDocument";
    }
}

class DocumentFactory{
    public documents CreateDocument(String entry){
        if(entry.trim().equalsIgnoreCase("Word Document")){
            return new WordDocument(); 
        }else if(entry.trim().equalsIgnoreCase("Pdf Document")){
            return new PdfDocument();
        }else if(entry.trim().equalsIgnoreCase("Excel Document")){
            return new ExcelDocument();
        }else{
            return null;
        }
    }
}

public class FactoryMethodPatternExample {
    public static void main(String[] args) {
        DocumentFactory user = new DocumentFactory();
        documents a = user.CreateDocument("Pdf Document"); 
        System.out.println(a.document()); 
        documents b = user.CreateDocument("Excel Document"); 
        System.out.println(b.document());
        documents c = user.CreateDocument("Word Document"); 
        System.out.println(c.document());
    }
    
}
