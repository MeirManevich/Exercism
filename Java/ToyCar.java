public class ElonsToyCar {
    public int m=0;
    public int batt=100;
    
    public static ElonsToyCar buy() {
        return new ElonsToyCar();
    }
    public String distanceDisplay() {
        return "Driven "+m+" meters";
    }
    public String batteryDisplay() {
        if (batt>0){
            return "Battery at "+batt+"%";
        }
        else{
            return "Battery empty";
        }
    }
    public void drive() {
        if (batt>0){
            m+=20;
            batt-=1;
        }
        
    }
}
