class BirdWatcher {
    private final int[] birdsPerDay;
    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }
    public int[] getLastWeek() {
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
    }
    public int getToday() {
        int l = birdsPerDay.length;
        return birdsPerDay[l-1];
    }
    public void incrementTodaysCount() {
        int l = birdsPerDay.length;
        birdsPerDay[l-1] += 1;
    }
    public boolean hasDayWithoutBirds() {
        for (int i : birdsPerDay){
            if (i == 0){
                return true;
            }
        }
        return false;
    }
    public int getCountForFirstDays(int numberOfDays) {
        int sum=0;
        if(numberOfDays>birdsPerDay.length) {
            for(int j=0; j<birdsPerDay.length; j++){
                sum += birdsPerDay[j];
                }
            return sum;
        }
        else {
            for (int j=0; j<numberOfDays; j++){
            sum += birdsPerDay[j];
            }
            return sum;
        }
        
    }
    
    public int getBusyDays() {
        int busy=0;
        for (int k : birdsPerDay){
            if (k>=5){
                busy++;
            }
        }
        return busy;
    }
}
