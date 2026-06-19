class Computer{
    private  String Cpu;
    private  int RAM;
    private  int Storage;
    
    private Computer(compBuilder Builder){
        this.Cpu = Builder.Cpu;
        this.RAM = Builder.RAM;
        this.Storage = Builder.Storage;
    }

    @Override
    public String toString() {
        return "Cpu: "+this.Cpu+" RAM: "+this.RAM+" Storage: "+this.Storage;
    }


    static class compBuilder{
        private  String Cpu;
        private  int RAM;
        private  int Storage;

        public compBuilder(){

        }
        public compBuilder setCpu(String cpu) {
            this.Cpu = cpu;
            return this; 
        }
        public compBuilder setRAM(int rAM) {
            this.RAM = rAM;
            return this;
        }
        public compBuilder setStorage(int storage) {
            this.Storage = storage;
            return this;
        }
        public Computer Build(){
            Computer User = new Computer(this); 
            return User;

        }
        
    }

}


public class BuilderPatternExample {
    public static void main(String[] args) {
        Computer user = new Computer
        .compBuilder()
        .setCpu("i5")
        .setRAM(8)
        .setStorage(248)
        .Build(); 

        System.out.println(user);
    }
}
