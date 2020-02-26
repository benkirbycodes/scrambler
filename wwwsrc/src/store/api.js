import Axios from "axios";
let baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

const API = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
});

export let api = API;
