class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder cleanid = new StringBuilder();
        Boolean isCaps = false;
        for (char c : identifier.toCharArray()){
                switch (c) {
                    case ' ':
                        cleanid.append('_');
                        break;
                    case '4':
                        cleanid.append('a');
                        break;
                    case '3':
                        cleanid.append('e');
                        break;
                    case '0':
                        cleanid.append('o');
                        break;
                    case '1':
                        cleanid.append('l');
                        break;
                    case '7':
                        cleanid.append('t');
                        break;
                }
                if (c=='-') {
                    isCaps=true;
                    }
                else if (isCaps==true){
                    c = Character.toUpperCase(c);
                    cleanid.append(c);
                    isCaps=false;
                }
                else if (Character.isLetter(c)){
                    cleanid.append(c);
                }
            }
        return cleanid.toString();
    }
}
