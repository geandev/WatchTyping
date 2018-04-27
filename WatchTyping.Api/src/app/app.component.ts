import { Component, Input, OnInit } from '@angular/core';
import { HubConnection } from '@aspnet/signalr-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit {

  private hubConnection: HubConnection;

  public code = '';
  public message = '';

  ngOnInit() {
    this.startHubConnection('/watchtyping');
  }

  join(code) {
    this.joinGroup(code);
    this.registerUserJoinGroupEvent();
    this.registerUserWrintingTextEvent();
  }

  typing(message) {
    this.updateMessage(message);
  }

  private startHubConnection(route) {
    this.hubConnection = new HubConnection(route);
  }

  private joinGroup(code) {
    this.code = code;
    this.hubConnection
      .start()
      .then(() => this.hubConnection.invoke('JoinGroupAsync', this.code))
      .catch(console.error);
  }

  private updateMessage(message) {
    this.message = message;
    this.hubConnection.invoke('UpdateMessageAsync', this.code, this.message);
  }

  private registerUserJoinGroupEvent() {
    this.hubConnection.on('UserJoinGroupEvent', (message) => { this.message = message; });
  }

  private registerUserWrintingTextEvent() {
    this.hubConnection.on('UserWritingTextEvent', message => { this.message = message; });
  }

}
