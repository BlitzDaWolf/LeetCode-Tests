package Solutions;

public class convertToTitleClass {
    public convertToTitleClass() {
        convertToTitle(1);
        convertToTitle(28);
        convertToTitle(701);
    }
    public String convertToTitle(int columnNumber) {
        if (columnNumber <= 0) return "";
        int index = columnNumber > 26?columnNumber%26:columnNumber;
        index = index==0?26:index;
        return convertToTitle((int)Math.ceil((columnNumber-26d)/26d)) + ((char)(index+64))+"";
    }
}
