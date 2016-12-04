package xcarpaccio;

import net.codestory.http.Configuration;
import net.codestory.http.payload.Payload;
import net.codestory.http.routes.Routes;

public class WebConfiguration implements Configuration {

    private final Logger logger = new Logger();

    @Override
    public void configure(Routes routes) {
        routes.
                get("/ping", "pong").
                post("/feedback", (context) -> {
                    Message message = context.extract(Message.class);
                    logger.log(message.type + ": " + message.message);
                    return new Payload(204);
                }).
                post("/quote", (context -> {
                    String method = context.method();
                    String uri = context.uri();
                    String body = context.extract(String.class);
                    logger.log(method + " " + uri + " " + body);
                    Quote quote = context.extract(Quote.class);
                    logger.log("Unserialized quote: " + quote);

                    double total = 42.0;
                    Answer answer = new Answer(total);
                    return new Payload("application/json", answer, 200);
                }))
        ;
    }
}
