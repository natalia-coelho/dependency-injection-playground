package coelho.natalia;

//@Component
public class CarService {
    // instead of carDAO = new carDAO();
    // Do this as a constructor dependency:
    private CarDAO carDAO;
    private EmailService emailService;
    private MOTService motService;

    //  @AutoWired/@Inject
    public CarService(CarDAO carDAO, EmailService emailService, MOTService motService) {
        this.carDAO = carDAO;
    }

}
