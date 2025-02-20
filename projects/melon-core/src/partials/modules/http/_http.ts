import { _HttpEndpoint } from "./constructors/_HttpEndpoint"
import { _Response } from "./constructors/_Response"
import { _app } from "./_app"
import { _request } from "./_request"
import { _requestAsync } from "./_requestAsync"
import { _result } from "./_result"
import { _static } from "./_static"

const _http = {
    _apps: {},
    request: _request,
    requestAsync: _requestAsync,
    app: _app,
    result: _result,
    static: _static,
}

export { _http }