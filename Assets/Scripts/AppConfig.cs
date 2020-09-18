using System;

public class AppConfig {

    private static AppConfig instance;

    //Game variables
    public int temperature = 0;

    private AppConfig() {
        initVars();
    }

    public static AppConfig sharedInstance() {
        if(instance == null) {
            instance = new AppConfig();
        }
        return instance;
    }

    private void initVars() {
        temperature = new Random().Next (101,105);
    }
}