import { Component } from '@angular/core';
import { HubConnection } from '@aspnet/signalr-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'app';
  hubConnection: HubConnection;

  ngOnInit() {
    this.hubConnection = new HubConnection('/watchtyping');
  }

  joined(code) {
    this.hubConnection
      .start()
      .then(() => {
        this.hubConnection.invoke("UpdateMessageAsync", code, "Gean Alexandre")
      })
      .catch(err => console.log('Error while establishing connection :('));
  }
}
