package Solutions;

public class accountBalanceAfterPurchaseClass {
    public int accountBalanceAfterPurchase(int purchaseAmount) {
        return 100 - Math.round(purchaseAmount / 10f) * 10;
    }
}
