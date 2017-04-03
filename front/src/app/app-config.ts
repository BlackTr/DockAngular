import {Injectable} from '@angular/core';

@Injectable()
export class AppConfig {
    apiEndpoint: string = "http://localhost:5000/api/";
}