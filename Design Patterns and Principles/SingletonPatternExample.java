class Logger{
    private static Logger logger; 
    private Logger(){
        System.out.println("Object created!");
    }
    public static Logger getInstance(){

        if(logger == null){
            synchronized(Logger.class){
                if(logger == null){
                    logger = new Logger();
                }
            }
        }
    
        return logger;
    }
}


public class SingletonPatternExample {
    public static void main(String[] args) {
        Logger log1 = Logger.getInstance(); 
        Logger log2 = Logger.getInstance();
        System.out.println(log1.hashCode());
        System.out.println(log2.hashCode());
    }
    
}
