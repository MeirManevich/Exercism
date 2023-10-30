public class CarsAssemble {
    public double productionRatePerHour(int speed) {
        if(speed==10){
            return speed*221*0.77;
        }
        else if (speed==9){
            return speed*221*0.80;
        }
        else if (speed>=5){
            return speed*221*0.9;
        }
        else {
            return speed*221;  
        }
    }
    public int workingItemsPerMinute(int speed) {
        if(speed==10){
            return (int) Math.floor(speed*221*0.77/60);
        }
        else if (speed==9){
            return (int) Math.floor(speed*221*0.80/60);
        }
        else if (speed>=5){
            return (int) Math.floor(speed*221*0.9/60);
        }
        else {
            return (int) Math.floor(speed*221/60);  
        }
    }
}
