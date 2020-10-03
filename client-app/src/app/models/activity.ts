import { toJS } from "mobx";

export interface IActivity {
  id: string;
  title: string;
  description: string;
  category: string;
  date: Date;
  city: string;
  venue: string;
  isGoing: boolean;
  isHost: boolean;
  attendees: IAttendee[];
}

export interface IAttendee {
  username: string;
  displayName: string;
  image: string;
  isHost: boolean;
}

export interface IActivityFormValues extends Partial<IActivity> {
  time?: Date;
}

export class ActivityFormValues implements IActivityFormValues {
  id?: string = undefined;
  title: string = "";
  category: string = "";
  description: string = "";
  date?: Date = undefined;
  time?: Date = undefined;
  city: string = "";
  venue: string = "";

  constructor(init?: IActivityFormValues) {
    let activity = toJS(init);
    if (activity && activity.date) {
      activity.time = activity.date;
    }
    Object.assign(this, activity);
  }
}
