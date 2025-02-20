import { Melon } from "../../../index";
import { _HttpApplication } from "./constructors/_HttpApplication";
import { _http } from "./_http";

function _app(options = 
    { 
        name: "webapp", 
        host: "localhost", 
        port: 80, 
        enableHttps: false 
    }
): _HttpApplication {
    const name = options.name;
    const host = options.host;
    const port = options.port;
    const enableHttps = options.enableHttps ?? false;

    Melon.http._apps[name] = new _HttpApplication(name, host, port, enableHttps);
    return _http._apps[name];
}

export { _app }