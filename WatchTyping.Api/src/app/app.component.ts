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
  text = ''
  code = ''

  ngOnInit() {
    this.hubConnection = new HubConnection('/watchtyping');
  }

  joined(code) {
    this.hubConnection
      .start()
      .then(() => {
        this.code = code
        this.hubConnection.invoke("JoinGroupAsync", code)
        console.info("joined")
      })
      .catch(err => console.log('Error while establishing connection :('));

    this.hubConnection.on("UserWritingTextEvent", data => {
      this.text = data
    })
  }

  typing(text) {
    this.hubConnection.invoke("UpdateMessageAsync", this.code, text)
  }
}
