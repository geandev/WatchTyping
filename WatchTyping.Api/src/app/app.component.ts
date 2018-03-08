import { Component, Input } from '@angular/core'
import { HubConnection } from '@aspnet/signalr-client'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {

  hubConnection: HubConnection
  code = ""
  text = ""

  ngOnInit() {
    this.hubConnection = new HubConnection('/watchtyping')
  }

  joined(code) {
    this.code = code

    this.hubConnection
      .start()
      .then(() => this.hubConnection.invoke("JoinGroupAsync", this.code))
      .catch(console.error)

    this.hubConnection.on("UserJoinGroupEvent", message => { this.text = message.text })
    this.hubConnection.on("UserWritingTextEvent", message => { this.text = message })
  }

  typing(text) {
    this.hubConnection.invoke("UpdateMessageAsync", this.code, text)
  }
}
