class SqueakyClean {
    static String clean(String identifier) {
        
        String newIdentifier = identifier;
        for (int i=0;i<identifier.length();i++){
            switch(newIdentifier.charAt(i)){
                case '4':
                    newIdentifier = newIdentifier.replace('4','a');
                case '3':
                    newIdentifier = newIdentifier.replace('3','e');
                case '0':
                    newIdentifier = newIdentifier.replace('0','o');
                case '1':
                    newIdentifier = newIdentifier.replace('1','l');
                case '7':
                    newIdentifier = newIdentifier.replace('7','t');
                case ' ':
                    newIdentifier = newIdentifier.replace(' ','_');
                }
            }
       
        if (newIdentifier.contains("¡")){
            newIdentifier =
        newIdentifier.substring(newIdentifier.indexOf("¡")+1,
                                newIdentifier.indexOf("!"))
                +newIdentifier.substring(newIdentifier.indexOf("!")+1);
        }
        String d = newIdentifier;
        for (int i=0;i<d.length();i++){
            if (!Character.isLetter(d.charAt(i)) && d.charAt(i)!='_' && d.charAt(i)!='-'){
                System.out.println(d.charAt(i)+": nope, not a letter");
                d=d.substring(0,d.indexOf(d.charAt(i)))+d.substring(d.indexOf(d.charAt(i))+1); 
                i=i-1;
                System.out.println("Current string: "+d);
            }
            else{
                System.out.println(d.charAt(i)+": yup yup");
                System.out.println("Current string: "+d);
            }
        }
        newIdentifier = d;
        
        System.out.println(newIdentifier);
        if (newIdentifier.contains("-")){
            String a= newIdentifier.substring(0,newIdentifier.indexOf("-"));
            String b= newIdentifier.substring(newIdentifier.indexOf("-")+1,newIdentifier.indexOf("-")+2).toUpperCase();
            String c= newIdentifier.substring(newIdentifier.indexOf("-")+2);
            return (a+b+c);
        }
        else {
            return newIdentifier;
        }
        
    }
}