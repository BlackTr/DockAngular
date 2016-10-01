import {Component, OnInit} from '@angular/core';
import {AppConfig} from "./app-config";
import {Http, Response, RequestOptions, Headers} from '@angular/http'
import {Todo} from "./todo";

@Component({
    selector: 'my-app',
    template: `<h1>My First Angular App</h1>
        <ul>
            <li *ngFor="let todo of todos">
                <span >{{todo.name}}</span>
            </li>
        </ul>
        New todo:
        <input #newName />
        <button (click)="addTodo(newName.value); newName.value=''">
          Add
        </button>
        <div class="error" *ngIf="errorMessage">{{errorMessage}}</div>
    `
})
export class AppComponent implements OnInit {
    todos: Todo[];
    errorMessage: string;

    constructor(private _config: AppConfig, private _http: Http) {
    }

    private extractData(res: Response) {
        let body = res.json();
        return body.data || { };
    }

    addTodo (name: string) {
        if (!name) { return; }
        let body = JSON.stringify({ name });
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this._http.post(this._config.apiEndpoint + 'todo', body, options).subscribe(res => {
            console.log("Result:");
            console.log(res);
            this.todos.push(res.json()),
            console.log(this.todos);
        }, error => {
            console.log("Error:");
            console.log(error);
            this.errorMessage = <any>error;
        });
    }

    ngOnInit() {
        this._http.get(this._config.apiEndpoint + 'todo').subscribe(res => {
            console.log("Result:");
            console.log(res);
            this.todos = res.json();
            console.log(this.todos);
        }, error => {
            console.log("Error:");
            console.log(error);
            this.errorMessage = <any>error;
        });
    }
}
