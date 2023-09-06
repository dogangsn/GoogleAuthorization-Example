import { SocialAuthService, SocialUser } from '@abacritt/angularx-social-login';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private socialAuthService: SocialAuthService, private httpClient: HttpClient) {
    this.socialAuthService.authState.subscribe((user: SocialUser) => {
      httpClient.post("https://localhost:7088/api/auth/", user).subscribe(token => console.log(token))
    });
  }


  ngOnInit() {
  }

}
