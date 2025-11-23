import { Component, OnInit } from '@angular/core';
import { EventsService } from '../services/events';
import { Event } from '../models/events';

@Component({
  selector: 'app-prodacts-list-page',
  templateUrl: './prodact-list-page.html',
  styleUrls: ['./prodact-list-page.css'],
})
export class ProdactsListPage implements OnInit {
  events: Event[] = [];

  constructor(private eventService: EventsService) { }

  ngOnInit(): void {
    this.eventService.getEvents().subscribe(data => {
      this.events = data;
    });
  }
}
