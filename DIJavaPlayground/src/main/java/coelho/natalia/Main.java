package coelho.natalia;

public class Main {
    public static void main(String[] args) {

        //dependencies
        CarDAO carDAO = new CarDAO();
        EmailService emailService = new EmailService();
        MOTService motService = new MOTService(emailService);

        //inject
            //CarService needs the dependencies specified in the constructor
        CarService carService = new CarService(
                carDAO,
                emailService,
                motService);

    }
}
