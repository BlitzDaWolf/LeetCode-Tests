package Solutions;

public class reverseBitsClass {
    public reverseBitsClass() {
        reverseBits(0b00000010100101000001111010011100);
        reverseBits(0b11111111111111111111111111111101);
    }

    public int reverseBits(int n) {
        return Integer.reverse(n);
    }
}
