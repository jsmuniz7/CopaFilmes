import axios from "axios";

export default axios.create({
  baseURL: "https://copadosfilmes.azurewebsites.net/api"
});
