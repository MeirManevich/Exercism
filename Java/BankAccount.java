class BankAccount {
    public int balance;
    public boolean status = false;
    void open() throws BankAccountActionInvalidException {
        if(status==false){
            BankAccount a = new BankAccount();
            status = true;
        }
        else{
            throw new BankAccountActionInvalidException("Account already open");
        }
    }
    void close() throws BankAccountActionInvalidException {
        if(status==true){
            status = false;
            balance = 0;
        }
        else{
            throw new BankAccountActionInvalidException("Account not open");
        }
    }
    synchronized int getBalance() throws BankAccountActionInvalidException {
        if(status==true){
            return this.balance;
        }
        else{
            throw new BankAccountActionInvalidException("Account closed");
        }
    }
    synchronized void deposit(int amount) throws BankAccountActionInvalidException {
        if(status==true && amount>0){
            balance += amount;
        }
        else if (amount<=0){
            throw new BankAccountActionInvalidException("Cannot deposit or withdraw negative amount");
        }
        else{
            throw new BankAccountActionInvalidException("Account closed");
        }
    }
    synchronized void withdraw(int amount) throws BankAccountActionInvalidException {
        if(status==true && amount>0 && balance>=amount){
            balance -= amount;
        }
        else if(status==false){
            throw new BankAccountActionInvalidException("Account closed");
        }
        else if (amount<=0){
            throw new BankAccountActionInvalidException("Cannot deposit or withdraw negative amount");
            }
        else if (balance<amount){
            throw new BankAccountActionInvalidException("Cannot withdraw more money than is currently in the account");  
        }
        
        
    }
}