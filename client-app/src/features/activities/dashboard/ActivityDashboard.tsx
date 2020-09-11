import React, { useContext } from "react";
import { Grid } from "semantic-ui-react";
import ActivityList from "./ActivityList";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import { observer } from "mobx-react-lite";
import ActivityStore from "../../../app/stores/activityStore";

const ActivityDashboard: React.FC = () => {
  const activityStore = useContext(ActivityStore);
  const { selectedActivity, editMode } = activityStore;

  return (
    <Grid>
      <Grid.Column key="list" width={10}>
        <ActivityList />
      </Grid.Column>
      <Grid.Column key="details" width={6}>
        {selectedActivity && !editMode && (
          <ActivityDetails />
        )}
        {editMode && (
          <ActivityForm
            key={selectedActivity?.id || 0}
            activity={selectedActivity!}
          />
        )}
      </Grid.Column>
    </Grid>
  );
};

export default observer(ActivityDashboard);
