import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class RMIServer {
    public static void main(String[] args) {
        try {
            RemoteImpl remoteImpl = new RemoteImpl();
            Registry registry = LocateRegistry.createRegistry(1099);
            registry.bind("HelloService", remoteImpl);
            System.out.println("Server ready");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}