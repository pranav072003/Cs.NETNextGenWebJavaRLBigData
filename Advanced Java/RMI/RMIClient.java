import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class RMIClient {
    public static void main(String[] args) {
        try {
            Registry registry = LocateRegistry.getRegistry("localhost", 1099);
            RemoteInterface remoteInterface = (RemoteInterface) registry.lookup("HelloService");
            String message = remoteInterface.sayHello();
            System.out.println(message);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}