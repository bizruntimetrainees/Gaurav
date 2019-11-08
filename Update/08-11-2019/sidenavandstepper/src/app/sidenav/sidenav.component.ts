import {Component} from '@angular/core';
import {FormControl} from '@angular/forms';


@Component({
  selector: 'app-sidenav',
  templateUrl: './Sidenav.component.html',
  styleUrls: ['./Sidenav.component.css'],
})
export class SidenavComponent {
  mode = new FormControl('over');
  shouldRun = [/(^|\.)plnkr\.co$/, /(^|\.)stackblitz\.io$/].some(h => h.test(window.location.host));
}